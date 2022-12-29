namespace HR.LeaveManagement.Application.Features.LeaveRequest.Handlers.Commands
{
    using AutoMapper;
    using HR.LeaveManagement.Domain;
    using HR.LeaveManagement.Application.Exceptions;
    using HR.LeaveManagement.Application.Features.LeaveRequest.Requests.Commands;
    using HR.LeaveManagement.Application.Features.LeaveRequest.Validators;
    using HR.LeaveManagement.Application.Contracts.Persistence;
    using MediatR;
    using System.Threading;
    using System.Threading.Tasks;
    using HR.LeaveManagement.Application.Contracts.Infrastructure;
    using HR.LeaveManagement.Application.Models;

    public class CreateLeaveRequestCommandHandler : IRequestHandler<CreateLeaveRequestCommand, int>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IEmailSender _emailSender;
        private readonly IMapper _mapper;

        public CreateLeaveRequestCommandHandler(
            ILeaveRequestRepository leaveRequestRepository,
            ILeaveTypeRepository _leaveTypeRepository,
            IEmailSender emailSender,
            IMapper mapper)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _leaveTypeRepository = _leaveTypeRepository;
            _mapper = mapper;
            _emailSender = emailSender;
        }

        public async Task<int> Handle(CreateLeaveRequestCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateLeaveRequestDtoValidator(_leaveTypeRepository);
            var validatorResult = await validator.ValidateAsync(request.LeaveRequestDto);

            if (validatorResult.IsValid == false)
            {
                throw new ValidationException(validatorResult);
            }

            var leaveRequest = _mapper.Map<LeaveRequest>(request.LeaveRequestDto);

            leaveRequest = await _leaveRequestRepository.Add(leaveRequest);

            var email = new Email
            {
                To = "vlad.chirila@live.com",
                Body = $"Your leave request for {request.LeaveRequestDto.StartDate} to {request.LeaveRequestDto.EndDate}",
                Subject = "Leave request submitted!"
            };

            try
            {
                await _emailSender.SendEmail(email);
            }
            catch (Exception ex)
            {
                //log
            }

            return leaveRequest.Id;
        }
    }
}

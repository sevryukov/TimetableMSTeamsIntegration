using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Graph;
using TimetableMSTeamsIntegration.Domain.Entities;
using TimetableMSTeamsIntegration.Application.Services;

namespace TimetableMSTeamsIntegration.Infrastructure.GraphClient
{
    public class MSGraphClient : IMSGraphClient
    {
        private readonly GraphServiceClient _graphClient;
        public MSGraphClient(GraphServiceClient graphClient)
            => _graphClient = graphClient;

        public Task AddMemberAsync(Guid memberId, Guid teamId)
        {
            // TODO: implement
            throw new NotImplementedException();
        }

        public Task CancelMeetingAsync(Guid meetingId)
        {
            // TODO: implement
            throw new NotImplementedException();
        }

        public Task CloseTeamAsync(Guid teamId)
        {
            // TODO: implement
            throw new NotImplementedException();
        }

        public async Task CreateMeetingAsync(string subject, DateTime start, DateTime end,  List<TeamMember> аttendees)
        {
            var attendeesToAdd = new List<Attendee>();
            foreach (TeamMember person in аttendees)
            {
                attendeesToAdd.Add(new Attendee
                {
                    EmailAddress = new EmailAddress
                    {
                        Name = person.FullName,
                        Address = person.Email
                    },
                    Type = AttendeeType.Required
                });

            }
            var @event = new Event
            {
                Subject = subject,
                Body = new ItemBody
                {
                    ContentType = BodyType.Html,
                    Content = "Some description"
                },
                Start = new DateTimeTimeZone
                {
                    DateTime = "2020-08-19T12:00:00",
                    TimeZone = "Pacific Standard Time"
                },
                End = new DateTimeTimeZone
                {
                    DateTime = "2020-08-19T13:00:00",
                    TimeZone = "Pacific Standard Time"
                },
                Attendees = attendeesToAdd,
                IsOnlineMeeting = true,
                OnlineMeetingProvider = OnlineMeetingProviderType.TeamsForBusiness

            };
            await _graphClient.Me.Events
            .Request()
            .Header("Prefer","outlook.timezone=\"Pacific Standard Time\"")
            .AddAsync(@event);
        } 
        public async Task CreateMeetingAsync(string subject, DateTime start, DateTime end,  List<Guid> аttendees)
        {
            var attendeesToAdd = new List<Attendee>();
            //TODO: implement method to get members by their ids 
             var @event = new Event
            {
                Subject = subject,
                Body = new ItemBody
                {
                    ContentType = BodyType.Html,
                    Content = "Some description"
                },
                Start = new DateTimeTimeZone
                {
                    DateTime = "2020-08-19T12:00:00",
                    TimeZone = "Pacific Standard Time"
                },
                End = new DateTimeTimeZone
                {
                    DateTime = "2020-08-19T13:00:00",
                    TimeZone = "Pacific Standard Time"
                },
                Attendees = attendeesToAdd,
                IsOnlineMeeting = true,
                OnlineMeetingProvider = OnlineMeetingProviderType.TeamsForBusiness

            };
            await _graphClient.Me.Events
            .Request()
            .Header("Prefer","outlook.timezone=\"Pacific Standard Time\"")
            .AddAsync(@event);

             
        }

        public Task<Guid> CreateTeamAsync(Guid discipline, Guid division, Guid contingentUnit, int year, int semester, ICollection<Guid> members = null)
        {
            // TODO: implement
            throw new NotImplementedException();
        }

        public Task RemoveMemberAsync(Guid memberId, Guid teamId)
        {
            // TODO: implement
            throw new NotImplementedException();
        }

        public Task RemoveMembersAsync(IEnumerable<(Guid memberId, Guid teamId)> members)
        {
            // TODO: implement
            throw new NotImplementedException();
        }

        public Task FinishMeetingAsync(Guid meetingId)
        {
            // TODO: not implement
            throw new NotImplementedException();
        }

        public Task ShiftMeetingAsync(Guid meetingId, DateTime newStartTime)
        {
            // TODO: implement
            throw new NotImplementedException();
        }
    }
}
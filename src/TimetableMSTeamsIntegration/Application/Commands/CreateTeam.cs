using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using TimetableMSTeamsIntegration.Application.Services;
using TimetableMSTeamsIntegration.Domain.Entities.Aggregates.TeamAggregates;

namespace TimetableMSTeamsIntegration.Application.Commands
{
    public class CreateTeam : IRequest
    {

        public CreateTeam(
            string title,
            Guid contingentUnit,
            Guid discipline,
            Guid division,
            int year,
            int semester,
            ICollection<Guid> members = null)
        {
            Title = title;
            ContingentUnit = contingentUnit;
            Discipline = discipline;
            Division = division;
            Year = year;
            Semester = semester;
            Members = members;
        }
        public string Title { get; private set; }
        public Guid ContingentUnit { get; private set; }
        public Guid Discipline { get; private set; }
        public Guid Division { get; private set; }
        public ICollection<Guid> Members { get; private set; }
        public int Year { get; private set; }
        public int Semester { get; private set; }
    }

    public class CreateTeamHandler : IRequestHandler<CreateTeam>
    {
        private readonly IIntegrationRepository _integrationRepository;
        private readonly IMSGraphClient _graphClient;

        public CreateTeamHandler(
            IIntegrationRepository integrationRepository,
            IMSGraphClient graphClient)
        {
            _integrationRepository = integrationRepository;
            _graphClient = graphClient;
        }

        public async Task<Unit> Handle(CreateTeam request, CancellationToken cancellationToken)
        {
            // TODO: implement handling
            // create team via graph api
            // put information about team creation to db

            try
            {
                // creating team in MS Graph via API
                Guid teamId = await _graphClient.CreateTeamAsync(
                    request.Discipline,
                    request.Division,
                    request.ContingentUnit,
                    request.Year,
                    request.Semester,
                    request.Members // optional
                );

                // if everything ok, we know id of the team => event happened
                // we post it to database

                await _integrationRepository.CreateCreateTeamEventAsync(
                    request.Discipline,
                    request.Division,
                    request.ContingentUnit,
                    request.Year,
                    request.Semester);

                // new we need to add create members events:
                if (request.Members != null)
                {
                    await _integrationRepository.CreateRangeAddMemberEventAsync(
                        request.Members
                            .Select(x => (x, teamId))
                            .ToArray()
                    );
                }
            }
            catch (Exception)
            {
                // ? we might need some error handling and logging which should be placed here
                throw;
            }

            return Unit.Value;
        }
    }
}
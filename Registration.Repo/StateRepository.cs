using System;
using System.Collections.Generic;
using System.Linq;
using Registration.DataLayer;
using Registration.Domain;
using Registration.Repo.Interfaces;

namespace Registration.Repo
{
    public class StateRepository : IStateRepository
    {
        private readonly RegistrationContext context;

        public StateRepository(RegistrationContext context)
        {
            this.context = context;
        }

        public IEnumerable<State> Get()
        {
            var states = All;

            return states.AsEnumerable();
        }

        public State Get(int id)
        {
            if (id == default(int))
            {
                throw new ArgumentNullException(nameof(id), "The state id cannot be null.");
            }

            return Find(id);
        }

        private IQueryable<State> All
        {
            get { return context.States.Where(x => x.Id != default(int)); }
        }

        private State Find(int id)
        {
            return context.States.Find(id);
        }
    }
}
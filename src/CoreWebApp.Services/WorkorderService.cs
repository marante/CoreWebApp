using System;
using System.Collections.Generic;
using CoreWebApp.Data;

namespace CoreWebApp.Services
{
    public class WorkorderService : IWorkorderService
    {
        private readonly WorkorderDbContext _context;

        public WorkorderService (WorkorderDbContext context)
        {
            _context = context;
        }
        public void Add (Workorder order)
        {
            throw new NotImplementedException ();
        }

        public Workorder Get (int id)
        {
            throw new NotImplementedException ();
        }

        public IEnumerable<Workorder> GetAll ()
        {
            throw new NotImplementedException ();
        }

        public IEnumerable<Workorder> GetByObjNr ()
        {
            throw new NotImplementedException ();
        }
    }
}
using System;
using System.Collections.Generic;

namespace CoreWebApp.Data
{
    public interface IWorkorderService
    {
        IEnumerable<Workorder> GetAll ();
        IEnumerable<Workorder> GetByObjNr ();
        Workorder Get (int id);
        void Add (Workorder order);
    }
}
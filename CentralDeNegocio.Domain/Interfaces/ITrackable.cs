using System;

namespace CentralDeNegocio.Domain.Interfaces
{
    public interface ITrackable
    {
        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }
    }
}

using AsilMedia.Domain.Entities;
using AsilMedia.Domain.Enums;

namespace AsilMedia.Application.DataTransferObjects
{
    public class ActorDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
        public Gender Gender { get; set; }
        public string PhotoPath { get; set; }

        public List<Film> Films { get; set; }
    }
}

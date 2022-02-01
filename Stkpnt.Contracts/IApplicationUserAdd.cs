using System;

namespace Stkpnt.Contracts
{
    public interface IApplicationUserAdd
    {
        Guid Id { get; set; }
        string Name { get; set; }
        string Surname { get; set; }
        string Patronymic { get; set; }
        string Email { get; set; }
    }
}
using ApiPNB.entities;

namespace ApiPNB.Interfaces
{
    public interface IPnbRestCpf
    {
          JsonCpf ProcessaAsync(string cpf);
    }
}
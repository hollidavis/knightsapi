using System;
using System.Collections.Generic;
using knightsapi.Models;
using knightsapi.Repositories;

namespace knightsapi.Services
{
  public class CastlesService
  {
    private readonly CastlesRepository _repo;

    public CastlesService(CastlesRepository repo)
    {
      _repo = repo;
    }

    internal IEnumerable<Castle> Get()
    {
      return _repo.Get();
    }

    internal Castle Get(int id)
    {
      Castle castle = _repo.Get(id);
      if (castle == null)
      {
        throw new Exception("Invalid Id");
      }
      return castle;
    }

    internal Castle Create(Castle newCastle)
    {
      Castle castle = _repo.Create(newCastle);
      if (castle == null)
      {
        throw new Exception("Invalid Id");
      }
      return castle;
    }

    internal Castle Edit(Castle updatedCastle)
    {
      Castle original = Get(updatedCastle.Id);
      updatedCastle.Name = updatedCastle.Name != null ? updatedCastle.Name : original.Name;
      return _repo.Update(updatedCastle);
    }

    internal void Delete(int id)
    {
      Castle original = Get(id);
      _repo.Delete(original.Id);
    }
  }
}
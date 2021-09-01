using System;
using System.Collections.Generic;
using knightsapi.Models;
using knightsapi.Repositories;

namespace knightsapi.Services
{
  public class KnightsService
  {
    private readonly KnightsRepository _repo;

    public KnightsService(KnightsRepository repo)
    {
      _repo = repo;
    }

    internal IEnumerable<Knight> Get()
    {
      return _repo.Get();
    }

    internal Knight Get(int id)
    {
      Knight knight = _repo.Get(id);
      if (knight == null)
      {
        throw new Exception("Invalid Id");
      }
      return knight;
    }

    internal Knight Create(Knight newKnight)
    {
      Knight knight = _repo.Create(newKnight);
      if (knight == null)
      {
        throw new Exception("Invalid Id");
      }
      return knight;
    }

    internal Knight Edit(Knight updatedKnight)
    {
      Knight original = Get(updatedKnight.Id);
      updatedKnight.Name = updatedKnight.Name != null ? updatedKnight.Name : original.Name;
      return _repo.Update(updatedKnight);
    }

    internal void Delete(int id)
    {
      Knight original = Get(id);
      _repo.Delete(original.Id);
    }
  }
}
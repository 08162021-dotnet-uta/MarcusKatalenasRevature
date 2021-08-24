using System.Collections.Generic;

namespace Project0.StoreApplication.Domain.Interfaces
{

  public interface IRepo<T> where T : class
  {

    bool Delete();
    bool Insert(T entry);
    T Update();

    List<T> Select { get; }
  }
}
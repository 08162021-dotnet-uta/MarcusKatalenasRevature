using System.Collections.Generic;

namespace Project0.StoreApplication.Domain.Interfaces
{

  /// <summary>
  /// The interface used to drive all repository classes with the base methods on storing and retriving data of various class types objects
  /// </summary>
  /// <typeparam name="T"></typeparam>
  public interface IRepo<T> where T : class
  {

    bool Delete();
    bool Insert(T entry);
    T Update();

    List<T> Select();
  }
}
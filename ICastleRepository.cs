using GameOfThrones.Models;
using System;

public interface ICaslteRepository
{
	public ICaslteRepository()
	{
		List<Castle> GetAll();
		Castle GetById(int id);
		Add(Castle entity);
		Update(Castle entity);
		Delete(Castle entity);
	}
}

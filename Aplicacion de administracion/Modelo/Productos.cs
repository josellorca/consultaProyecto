using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

public class Productos
{
	public int IdProducto
	{
		get;
		set;
	}
	public string NomProducto
	{
		get;
		set;
	}
	public string DescProducto
	{
		get;
		set;
	}
	public string Especificaciones
	{
		get;
		set;
	}
	public int IdCategoria
	{
		get;
		set;
	}

	public double PrecioUnitario
	{
		get;
		set;
	}
	public int Stock
	{
		get;
		set;
	}
	public int Disponible
	{
		get;
		set;
	}


	public string ImgProducto
	{
		get;
		set;
	}


	public int Ranking
	{
		get;
		set;
	}

	public int Descuento
	{
		get;
		set;
	}

	public Productos()
	{

	}
	public Productos(int idProducto, string nomProducto, string descProducto, string especificaciones, int idCategoria, float precio, int disponible)
	{
		IdProducto = idProducto;
		NomProducto = nomProducto;
		DescProducto = descProducto;
		Especificaciones = especificaciones;
		IdCategoria = idCategoria;
		PrecioUnitario = precio;
		Disponible = disponible;
	}
	public Productos(string nomProducto, string descProducto, string especificaciones, int idCategoria, float precio, int disponible)
	{
		NomProducto = nomProducto;
		DescProducto = descProducto;
		Especificaciones = especificaciones;
		IdCategoria = idCategoria;
		PrecioUnitario = precio;
		Disponible = disponible;
	}
	public Productos(string nomProducto, string descProducto, string especificaciones, int idCategoria, float precio, int disponible, int descuento)
	{
		NomProducto = nomProducto;
		DescProducto = descProducto;
		Especificaciones = especificaciones;
		IdCategoria = idCategoria;
		PrecioUnitario = precio;
		Disponible = disponible;
		Descuento = descuento;
	}



}

using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;

public class Categoria: INotifyPropertyChanged
{
	public string DescripcionCat
	{
		get;
		set;
	}
	public int IdCategoria
	{
		get;
		set;
	}
	public string ImgCategoria
	{
		get;
		set;
	}
	public string NomCategoria
	{
		get;
		set;
	}

	public Categoria(string descripcionCat, string imgCategoria, string nomCategoria)
	{
		DescripcionCat = descripcionCat;
		ImgCategoria = imgCategoria;
		NomCategoria = nomCategoria;
	}

	public event PropertyChangedEventHandler PropertyChanged;
}

using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

public class Detallespedidos
{

	public int Cantidad
	{
		get { return Cantidad; }
		set { Cantidad = value; }
	}
	public int Descuento
	{
		get { return Descuento; }
		set { Descuento = value; }
	}
	public int IdPedido
	{
		get { return IdPedido; }
		set { IdPedido = value; }
	}
	public int IdProducto
	{
		get { return IdProducto; }
		set { IdProducto = value; }
	}
	public double Precio
	{
		get { return Precio; }
		set { Precio = value; }
	}

	public Detallespedidos(){ }

}

using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

public class Pago
{
	public enum FormaPago
	{
		Tarjeta,
		ContraReembolso
	}
	public int IdPago
	{
		get; 
		set; 
	}
	public FormaPago TipoPago
	{
		get; 
		set; 
	}

	public Pago(){ }

	public Pago(FormaPago tipoPago)
	{
		TipoPago = tipoPago;
	}
}

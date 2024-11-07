﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using DOMINIO;


namespace NEGOCIO
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select IdArticulo, Nombre, Descripcion, Precio, Tipo, CantidadDisponible from Articulo");

                datos.realizarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();

                    aux.IdArticulo = (int)datos.Lector["IdArticulo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.CantidadDisponible = (int)datos.Lector["CantidadDisponible"];                 
                    aux.Tipo = (int)datos.Lector["Tipo"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar los artículos: " + ex.Message);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public List<Articulo> ListarConSp()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearSp("storedCarta");
                datos.realizarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo
                    {
                        IdArticulo = (int)datos.Lector["IdArticulo"],
                        Nombre = (string)datos.Lector["Nombre"],
                        Descripcion = (string)datos.Lector["Descripcion"],
                        Precio = (decimal)datos.Lector["Precio"],
                        Tipo = (int)datos.Lector["Tipo"],
                        CantidadDisponible = (int)datos.Lector["CantidadDisponible"],
                    };

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar los artículos: " + ex.Message);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void agregarSP(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearProcedimiento("storedAltaArticulo");
                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@Descripcion", nuevo.Descripcion);
                datos.setearParametro("@Precio", nuevo.Precio);
                datos.setearParametro("@Tipo", nuevo.Tipo);
                datos.setearParametro("@Cantidad", nuevo.CantidadDisponible);

                datos.realizarAccion();

            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar articulo" + ex.Message);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}

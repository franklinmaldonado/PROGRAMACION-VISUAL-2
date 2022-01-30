using System;
using Proyecto.Entidades;
using System.Collections.Generic;

namespace CargaDatos
{
    public class Class1
    {
        private const double V = 12.5;

        public enum ListaTipo
        {
            Boletas, Categorias, Clientes, DetalleOrdenPedidos, Distritos,
            Empleados,OrdenPedidos,Presentaciones, Productos,Proveedores, Usuarios
        };

        public Dictionary<ListaTipo, object> CargaDatos()
        {
            //lista de boleta

            //lista de categorias
            #region
            Categoria aspirina = new Categoria()
            {
                nom_Descripcion = "medicamento para tratar el dolor",
            };
            Categoria diclofenaco = new Categoria()
            {
                nom_Descripcion = "tratamiento de artrosis"
            };
            List<Categoria> listacategorias = new List<Categoria>() { aspirina};
            #endregion
            //lista de clientes

            //lista de DetalleOrdenPedido

            //lista de Distritos
            #region
            Distrito Quito = new Distrito() {nom_Distrito = "Quito" };
            Distrito Montufar = new Distrito() {nom_Distrito = "Montufar" };
            Distrito Esmeraldas = new Distrito() {nom_Distrito = "Esmeraldas" };
            Distrito Quininde = new Distrito() {nom_Distrito = "Quininde" };
            Distrito Ibarra = new Distrito() {nom_Distrito = "Ibarra" };
            Distrito Pimampiro = new Distrito() {nom_Distrito = "Pimampiro" };
            Distrito Cotacachi = new Distrito() {nom_Distrito = "Cotacachi" };
            Distrito Cayambe = new Distrito() {nom_Distrito = "Cayambe" };
            Distrito Mejia = new Distrito() {nom_Distrito = "Mejia" };
            Distrito Sigchos = new Distrito() {nom_Distrito = "Sigchos" };
            Distrito Pangua = new Distrito() {nom_Distrito = "Pangua" };
            Distrito Pujili = new Distrito() {nom_Distrito = "Pujili" };
            Distrito Baños = new Distrito() {nom_Distrito = "Baños" };

            List<Distrito> listadistrito = new List<Distrito>() { Quito, Montufar, Esmeraldas, Quininde, Ibarra, Pimampiro, Cotacachi, Cayambe, Mejia, Sigchos, Pangua, Pujili, Baños };
            #endregion

            //lista de Empleados

            //lista de OrdenPedidos

            //lista de Presentacion
            #region
            Presentacion Bayer = new Presentacion() { nom_Presentacion = "Bayer" };
            Presentacion Laboratorio_Chile = new Presentacion() { nom_Presentacion = "Laboratorio Chile" };
            Presentacion MK = new Presentacion() { nom_Presentacion = "MK" };


            List<Presentacion> listapresentacion = new List<Presentacion>() { Bayer,Laboratorio_Chile };
            #endregion
            //lista de Proveedor
            #region
            Proveedor TecnandinaSA = new Proveedor()
            {
                nom_Proveedor = " Tecnandina",
                direc_Proveedor = "Av. Manuel Cordova Galarza KM 6.5",
                Telefono = 2278456,
                Celular = "0987455478",
                Distrito = Quito
            };
            Proveedor ANHEXA = new Proveedor()
            {
                nom_Proveedor = "ANHEXA",
                direc_Proveedor = "Jose Luis Tamayo #1025 y Lizardo Garcia Edificio Tamagar, 2",
                Telefono = 2235474,
                Celular = "0978412458",
                Distrito = Montufar
            };
            Proveedor Abbott = new Proveedor()
            {
                nom_Proveedor = "Abbott",
                direc_Proveedor = "Apartado 09-01-1292 Calicuchima 601",
                Telefono = 2145457,
                Celular = "0999478525",
                Distrito = Ibarra
            };
            Proveedor Baxter = new Proveedor()
            {
                nom_Proveedor = "Baxter",
                direc_Proveedor = "Casilla 17-17-1837 Diguja 190 y Vozandes",
                Telefono = 2278456,
                Celular = "0987455478",
                Distrito = Cayambe
            };
            Proveedor Calox = new Proveedor()
            {
                nom_Proveedor = "Calox",
                direc_Proveedor = "Panamericana Norte No. 10265",
                Telefono = 2354415,
                Celular = "0989741458",
                Distrito = Sigchos
            };

            List<Proveedor> listaproveedor = new List<Proveedor>() { TecnandinaSA };
            #endregion

            //lista de Producto 
            #region
            Producto Aspirina = new Producto()
            {
                nom_Producto = "Aspirina",
                precio_Venta = new decimal(0.5),
                fecha_Venc = new DateTime(2023-12-12),
                Stock = 50,
                Presentacion = Bayer,
                Categoria = aspirina,
                Proveedor = TecnandinaSA
            };
            Producto Diclofenaco = new Producto()
            {
                nom_Producto = "Diclofenaco",
                precio_Venta = new decimal(1.5),
                fecha_Venc = new DateTime(2023 - 11 - 12),
                Stock = 40,
                Presentacion = Laboratorio_Chile,
                Categoria = aspirina,
                Proveedor = TecnandinaSA
            };
            Producto Digoxina = new Producto()
            {
                nom_Producto = "Digoxina",
                precio_Venta = new decimal(2.5),
                fecha_Venc = new DateTime(2024 - 12 - 12),
                Stock = 55,
                Presentacion = Bayer,
                Categoria = aspirina,
                Proveedor = TecnandinaSA
            };
            Producto Aspirina = new Producto()
            {
                nom_Producto = "Aspirina",
                precio_Venta = new decimal(12.5),
                fecha_Venc = new DateTime(2023 - 12 - 12),
                Stock = 65,
                Presentacion = Bayer,
                Categoria = aspirina,
                Proveedor = TecnandinaSA
            };
            Producto Aspirina = new Producto()
            {
                nom_Producto = "Aspirina",
                precio_Venta = new decimal(12.5),
                fecha_Venc = new DateTime(2023 - 12 - 12),
                Stock = 85,
                Presentacion = Bayer,
                Categoria = aspirina,
                Proveedor = TecnandinaSA
            };
            Producto Aspirina = new Producto()
            {
                nom_Producto = "Aspirina",
                precio_Venta = new decimal(12.5),
                fecha_Venc = new DateTime(2023 - 12 - 12),
                Stock = 15,
                Presentacion = Bayer,
                Categoria = aspirina,
                Proveedor = TecnandinaSA
            };
            Producto Aspirina = new Producto()
            {
                nom_Producto = "Aspirina",
                precio_Venta = new decimal(12.5),
                fecha_Venc = new DateTime(2023 - 12 - 12),
                Stock = 96,
                Presentacion = Bayer,
                Categoria = aspirina,
                Proveedor = TecnandinaSA
            };
            Producto Aspirina = new Producto()
            {
                nom_Producto = "Aspirina",
                precio_Venta = new decimal(12.5),
                fecha_Venc = new DateTime(2023 - 12 - 12),
                Stock = 44,
                Presentacion = Bayer,
                Categoria = aspirina,
                Proveedor = TecnandinaSA
            };


            #endregion
            //lista de usuario



            Dictionary<ListaTipo, object> dicListaDatos = new Dictionary<ListaTipo, object>()
            {
                {ListaTipo.Boletas, listaboletas },
                {ListaTipo.Categorias, listacategorias },
                {ListaTipo.Clientes, listaclie },
                {ListaTipo.DetalleOrdenPedidos, listadeta },
                {ListaTipo.Distritos, listadistrito },
                {ListaTipo.Empleados, listaem },
                {ListaTipo.OrdenPedidos, listaorde },
                {ListaTipo.Presentaciones, listapresentacion },
                {ListaTipo.Productos, listadistrito },
                {ListaTipo.Proveedores, listaproveedor },
                {ListaTipo.Usuarios, listau },
            };
            return dicListaDatos;
        }
    }
}

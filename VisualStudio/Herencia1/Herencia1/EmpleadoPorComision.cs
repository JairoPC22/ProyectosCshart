using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia1
{
    internal class EmpleadoPorComision:Object
    {
        private string primerNombre;
        private string apellidoPaterno;
        private string numeroSeguroSocial;
        private decimal ventasBrutas; //Ventas semanales totales
        private decimal tarifaComision; //Porcentaje de comision

        //Constructor con cinco parametro
        public EmpleadoPorComision(string nombre, string apellido, string nss, decimal ventas, decimal tarifa) 
        {
            //Se realiza la llamada implicita al constructor del objeto que ocurre aqui
            primerNombre= nombre;
            apellidoPaterno= apellido;
            numeroSeguroSocial= nss;
            ventasBrutas= ventas; //Valida las ventas brutas mediante una propiedad
            tarifaComision = tarifa; //Valida la tarifa de comision mediante una propiedad 
        }//Fin de constructor EmpleadoPorComision con 5 parametros
        //Prpoedad de solo lectura que obtiene el primer nombre del empleado por comision
        public string PrimerNombre
        {
            get { return primerNombre; }
        //    set { primerNombre = value; }
        }
        //Propiedad de solo lectura que obtiene el apellido paterno del empleado por comision 
        public string ApellidoPaterno
        {
            get { return apellidoPaterno;}
        }
        //Propiedad de solo lectura que obtiene el numero de seguridad del empleado por comision
        public string NumeroSeguroSocial
        {
            get { return numeroSeguroSocial; }
        }
        //Propiedad que obtiene y establece las ventasbrutas del empleado por comision 
        public decimal VentasBrutas
        {
            get { return ventasBrutas;}
            set { ventasBrutas = (value<0)?0:value;}
        }
        //Propiedad que obtiene y establece la tarifa por comision del empleado por comision
        public decimal TarifaComision
        {
            get { return tarifaComision; }
            set { tarifaComision = (value > 0 && value < 1) ? value:0 ; }
        }
        //Metodo que calcula el salario del empleado por comision 
        public decimal Ingresos()
        {
            return tarifaComision * ventasBrutas;
        }
        //Devuelve la representacion string del objeto EmpleadoPorComision
        public override string ToString()
        {
            return string.Format("{0}:{1} {2}\n{3}: {4}\n{5}: "+
                "{6:C}\n{7}:{8:F2}","Empleado por comision", PrimerNombre, ApellidoPaterno,
                "Numero de seguridad social", NumeroSeguroSocial, "Ventas Brutas", 
                VentasBrutas, "Tarifa poc comision", TarifaComision);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL.Empleados;
using DTOs.Empleados;

namespace BLL.Empleados
{
    public class EmpleadosController
    {
        public EmpleadosController() { }

        public List<EmpleadoDTO> getEmpleados()
        {
            EmpleadosDLL empleadoDLL = new EmpleadosDLL();
            List<EmpleadoDTO> listaEmpleados = empleadoDLL.getEmpleados();

            return listaEmpleados;
        }

        public List<EmpleadoDTO> getEmpleadosPuesto(string puesto)
        {
            EmpleadosDLL empleadoDLL = new EmpleadosDLL();
            List<EmpleadoDTO> listaEmpleados = empleadoDLL.getEmpleadosPuesto(puesto);

            return listaEmpleados;
        }
    }
}

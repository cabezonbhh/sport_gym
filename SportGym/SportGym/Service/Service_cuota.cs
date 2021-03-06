﻿using SportGym.Business;
using SportGym.Data;
using SportGym.DataTransferObject;
using SportGym.Interface;
using SportGym.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportGym.Service
{
    public class Service_cuota
    {
        private IDAO_Cuota<Cuota> daoCuota;
        private MapperCuota mapCuota;
        public Service_cuota()
        {
            daoCuota = new DAO_Cuota();
            mapCuota = new MapperCuota();
        }
        public bool registrarNuevaCuota(DTO_Pagar_Cuota dto)
        {
            int nroSocio = Convert.ToInt32(dto.NroSocio);
            int nroInscripcion = Convert.ToInt32(dto.NroInscripcion);
            double monto = Convert.ToDouble(dto.Monto);
            DateTime inicio = Convert.ToDateTime(dto.FechaInicio);
            DateTime fin = Convert.ToDateTime(dto.FechaFin);
            return daoCuota.registrarCuota(nroSocio, nroInscripcion, monto, inicio, fin);
        }

        public bool tieneQuePagar(int nroSocio)
        {
            Service_socio service = new Service_socio();
            Cuota cuota = service.getSocioEntidad(nroSocio).Inscripcion.getUltimoPago();
            if (cuota == null || cuota.esVencida() == true)
                return true;
            else
                return false;
        }

        public IList<DTO_Cuota> getCuotasPorSocio(int nro)
        {
            IList<Cuota> listaCuotas = daoCuota.getCuotasPorSocio(nro);
            IList<DTO_Cuota> listaDto = new List<DTO_Cuota>();


            foreach(Cuota cuota in listaCuotas)
            {
                listaDto.Add(mapCuota.getDtoCuota(cuota));
            }

            return listaDto;
        }

        public DTO_Cuota getUltimaCuota(int nro)
        {
            Cuota cuota = daoCuota.getUltimaCuotaPorInscripcion(nro); 
            if(cuota !=null)
            {
                return mapCuota.getDtoCuota(cuota);
            }
            else
            {
                return null;
            }
        }


        public bool actualizarCuota(DTO_Cuota dto)
        {
            double monto = Convert.ToDouble(dto.Monto);
            DateTime inicio = Convert.ToDateTime(dto.FechaInicio);
            DateTime fin = Convert.ToDateTime(dto.FechaFin);
            int nro = Convert.ToInt32(dto.NroCuota);
            return daoCuota.actualizarCuota(nro,monto,inicio,fin);
        }

    }
}

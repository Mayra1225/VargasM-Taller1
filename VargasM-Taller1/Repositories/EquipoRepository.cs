using VargasM_Taller1.Models;

namespace VargasM_Taller1.Repositories
{
    public class EquipoRepository
    {
        public IEnumerable<Equipo> Equipos;

        public EquipoRepository()
        {
            Equipos = DevuelveListadoEquipos();
        }

        public IEnumerable<Equipo> DevuelveListadoEquipos()
        {
            List<Equipo> equipos = new List<Equipo>();

            Equipo ldu = new Equipo
            {
                Id = 1,
                Nombre = "Liga de Quito",
                PartidosEmpatados = 0,
                PartidosGanados = 10,
                PartidosJugados = 10,
                PartidosPerdidos = 0,
            };

            Equipo barceloina = new Equipo
            {
                Id = 2,
                Nombre = "Barcelona",
                PartidosEmpatados = 0,
                PartidosGanados = 8,
                PartidosJugados = 10,
                PartidosPerdidos = 2,
            };
            equipos.Add(ldu);
            equipos.Add(barceloina);

            return equipos;
        }

        public Equipo DevuelveEquipoporId(int Id)
        {
            var equipo = Equipos.First(item => item.Id == Id);

            return equipo;
        }

        public Boolean ActualizarEquipo(int Id, Equipo equpo)
        {
            return true;
        }
    }
}

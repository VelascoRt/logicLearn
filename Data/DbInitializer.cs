using logicLearn.Data;
using logicLearn.Models;

namespace ContosoUniversity.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            // Look for any clients.
            if (context.Clientes.Any())
            {
                return;   // DB has been seeded
            }

            var clientes = new Cliente[]
            {
                new Cliente{ClienteID=1,Apellido="Carson",Nombre="Alexander",Correo="JuanPerez1985@gmail.com"},
                new Cliente{ClienteID=2,Apellido="Meredith",Nombre="Alonso",Correo="AmorEterno33@gmail.com"},
                new Cliente{ClienteID=3,Apellido="Maria",Nombre="Anand",Correo="MariaRodriguez_23@gmail.com"},
                new Cliente{ClienteID=4,Apellido="Ana",Nombre="Barzdukas",Correo="AventurasDeAna_567@hotmail.com"},
                new Cliente{ClienteID=5,Apellido="Yan",Nombre="Li",Correo="FamiliaGomez87@gmail.com"},
                new Cliente{ClienteID=6,Apellido="Peggy",Nombre="Justice",Correo="CarlosAmigos2000@gmail.com"},
                new Cliente{ClienteID=7,Apellido="Laura",Nombre="Norman",Correo="LauraYCesar_42@hotmail.com"},
                new Cliente{ClienteID=8,Apellido="Nino",Nombre="Olivetto",Correo="Nino37123@gmail.com"}
            };

            context.Clientes.AddRange(clientes);
            context.SaveChanges();

            var courses = new Curso[]
            {
                new Curso{CursoID=1050,NombreCurso="React",Precio=250},
                new Curso{CursoID=4022,NombreCurso="Angular",Precio=250},
                new Curso{CursoID=4041,NombreCurso="Vue",Precio=250},
                new Curso{CursoID=1045,NombreCurso="JavaScript",Precio=200},
                new Curso{CursoID=3141,NombreCurso="Pythorch",Precio=350},
                new Curso{CursoID=2021,NombreCurso="Python",Precio=150}
            };

            context.Cursos.AddRange(courses);
            context.SaveChanges();

            var teachers = new Profesor[]
            {
                new Profesor{ProfesorID=1,Nombre="Larry",Apellido="Mendez"},
                new Profesor{ProfesorID=2,Nombre="Alejandro",Apellido="Vargas"},
                new Profesor{ProfesorID=3,Nombre="Ana",Apellido="Gomez"},
                new Profesor{ProfesorID=4,Nombre="Francisco",Apellido="Torres"},
                new Profesor{ProfesorID=5,Nombre="Isabella",Apellido="Lopez"},
                new Profesor{ProfesorID=6,Nombre="Javier",Apellido="Garcia"},
                new Profesor{ProfesorID=7,Nombre="Adriana",Apellido="Hernandez"},
                new Profesor{ProfesorID=8,Nombre="Manuel",Apellido="Sanchez"}
            };

            context.Profesores.AddRange(teachers);
            context.SaveChanges();

            var programmers = new Programador[]
            {
                new Programador{ProgramadoresID=1,Nombre="Victor",Apellido="Ortíz", Tarea="Mantenimiento"},
                new Programador{ProgramadoresID=2,Nombre="Ándres",Apellido="Sanchez", Tarea="Principal"},
                new Programador{ProgramadoresID=3,Nombre="Rafael",Apellido="Gomez", Tarea="Mantenimiento"},
            };

            context.Programadores.AddRange(programmers);
            context.SaveChanges();

            var materials = new Material[]
            {
                new Material{MaterialID=1,Nombre="Vídeos",Precio=150, Contenido="Vídeos grabados de la clase."},
                new Material{MaterialID=2,Nombre="Documentos",Precio=50, Contenido="Documentos usados en las clases."},
                new Material{MaterialID=3,Nombre="Material de apoyo 1",Precio=30, Contenido="Primera parte del material de apoyo"},
                new Material{MaterialID=4,Nombre="Material de apoyo 2",Precio=30, Contenido="Segunda parte del material de apoyo"},
                new Material{MaterialID=5,Nombre="Material de apoyo 3",Precio=30, Contenido="Tercera parte del material de apoyo"},
            };

            context.Materiales.AddRange(materials);
            context.SaveChanges();

            var pagos = new Plan[]
            {
                new Plan{PagoID=1,Nombre="Estándar",Precio=150},
                new Plan{PagoID=2,Nombre="Estudiante",Precio=50},
                new Plan{PagoID=3,Nombre="Premium",Precio=200}
            };

            context.Planes.AddRange(pagos);
            context.SaveChanges();

            var insc = new Inscripcion[]
            {
                new Inscripcion{ClienteID=1,CursoID=1050,PagoID=1},
                new Inscripcion{ClienteID=1,CursoID=4022,PagoID=1},
                new Inscripcion{ClienteID=1,CursoID=4041,PagoID=2},
                new Inscripcion{ClienteID=2,CursoID=1045,PagoID=1},
                new Inscripcion{ClienteID=2,CursoID=3141,PagoID=3},
                new Inscripcion{ClienteID=2,CursoID=2021,PagoID=1},
                new Inscripcion{ClienteID=3,CursoID=1050,PagoID=3},
                new Inscripcion{ClienteID=4,CursoID=1050,PagoID=2},
                new Inscripcion{ClienteID=4,CursoID=4022,PagoID=1},
                new Inscripcion{ClienteID=5,CursoID=4041,PagoID=3},
                new Inscripcion{ClienteID=6,CursoID=1050,PagoID=1},
                new Inscripcion{ClienteID=7,CursoID=3141,PagoID=1},
                new Inscripcion{ClienteID=8,CursoID=3141,PagoID=2}
            };

            context.Inscripciones.AddRange(insc);
            context.SaveChanges();

            var mat = new Tema[]
            {
                new Tema{ProfesorID=1,CursoID=1050,MaterialID=1},
                new Tema{ProfesorID=1,CursoID=4022,MaterialID=2},
                new Tema{ProfesorID=1,CursoID=4041,MaterialID=3},
                new Tema{ProfesorID=2,CursoID=1045,MaterialID=4},
                new Tema{ProfesorID=2,CursoID=3141,MaterialID=1},
                new Tema{ProfesorID=2,CursoID=2021,MaterialID=1},
                new Tema{ProfesorID=3,CursoID=1050,MaterialID=3},
                new Tema{ProfesorID=4,CursoID=1050,MaterialID=2},
                new Tema{ProfesorID=4,CursoID=4022,MaterialID=1},
                new Tema{ProfesorID=5,CursoID=4041,MaterialID=3},
                new Tema{ProfesorID=6,CursoID=1050,MaterialID=1},
                new Tema{ProfesorID=7,CursoID=3141,MaterialID=1},
                new Tema{ProfesorID=8,CursoID=3141,MaterialID=2}
            };

            context.Temas.AddRange(mat);
            context.SaveChanges();
        }
    }
}
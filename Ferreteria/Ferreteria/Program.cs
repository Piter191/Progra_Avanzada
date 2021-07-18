using BlibliotecaBodega.DAL;
using BlibliotecaBodega.DTO;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace Ferreteria
{
    class Program
    {
        public static void menuPrincipal()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            int op = -1;
            string opc;
            do
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(40, 5);
                Console.WriteLine("==============================================");
                Console.SetCursorPosition(40, 6);
                Console.WriteLine("|               MENÚ PRINCIPAL               |");
                Console.SetCursorPosition(40, 7);
                Console.WriteLine("==============================================");
                Console.SetCursorPosition(40, 8);
                Console.WriteLine("|    1.- Mantenedor de Usuarios              |");
                Console.SetCursorPosition(40, 9);
                Console.WriteLine("|    2.- Mantenedor de Familias Productos    |");
                Console.SetCursorPosition(40, 10);
                Console.WriteLine("|    3.- Mantenedor de Productos             |");
                Console.SetCursorPosition(40, 11);
                Console.WriteLine("|    4.- Salir del Sistema                   |");
                Console.SetCursorPosition(40, 12);
                Console.WriteLine("----------------------------------------------");
                Console.SetCursorPosition(40, 13);
                Console.WriteLine("|             Ingrese Opcion [ ]             |");
                Console.SetCursorPosition(70, 13);
                opc = Console.ReadLine().Trim();

                if (numero(opc))
                {
                    op = int.Parse(opc);
                }
                else
                {
                    op = -1;
                }
                if (op < 0 || op > 4)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(40, 14);
                    Console.WriteLine("¡Opción Inválida!");
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(40, 14);
                    Console.WriteLine("                     ");
                }


            } while (op < 0 || op > 4);

            switch (op)
            {

                case 1:
                    menuUsuario();
                    break;
                case 2:
                    menuFamilia();
                    break;
                case 3:
                    menuProducto();
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(40, 16);
                    Console.WriteLine("Saliendo del Sistema...");
                    Console.ReadLine();
                    break;
            }
        }

        public static bool numero(String num)
        {
            try
            {
                Int32.Parse(num);
                return true;
            }
            catch
            {
                return false;
            }
        }


        public static void menuUsuario()
        {

            int op = -1;
            string opc;
            do
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.SetCursorPosition(50, 3);
                Console.WriteLine("Fecha: {0}", DateTime.Now.ToString("dd/MM/yyyy"));
                Console.SetCursorPosition(50, 4);
                Console.WriteLine("Hora: {0}", DateTime.Now.ToString("H:mm:ss"));
                Console.SetCursorPosition(50, 5);
                Console.WriteLine("---------------------------------");
                Console.SetCursorPosition(50, 6);
                Console.WriteLine("|          MENÚ USUARIOS        |");
                Console.SetCursorPosition(50, 7);
                Console.WriteLine("---------------------------------");
                Console.SetCursorPosition(50, 8);
                Console.WriteLine("|    1.- Ingresar Usuario       |");
                Console.SetCursorPosition(50, 9);
                Console.WriteLine("|    2.- Modificar Usuario      |");
                Console.SetCursorPosition(50, 10);
                Console.WriteLine("|    3.- Eliminar Usuario       |");
                Console.SetCursorPosition(50, 11);
                Console.WriteLine("|    4.- Mostrar Usuarios       |");
                Console.SetCursorPosition(50, 12);
                Console.WriteLine("|    5.- Volver Menu Principal  |");
                Console.SetCursorPosition(50, 13);
                Console.WriteLine("---------------------------------");
                Console.SetCursorPosition(50, 14);
                Console.WriteLine("        Ingrese Opcion [ ]       ");
                Console.SetCursorPosition(74, 14);
                opc = Console.ReadLine().Trim();

                if (numero(opc))
                {
                    op = int.Parse(opc);
                }
                else
                {
                    op = -1;
                }
                if (op < 0 || op > 5)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(50, 15);
                    Console.WriteLine("¡Opción Inválida!");
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(50, 15);
                    Console.WriteLine("                     ");
                }
            } while (op < 0 || op > 5);

            switch (op)
            {

                case 1:
                    IngresarUsuario();
                    break;
                case 2:
                    ModificarUsuario();
                    break;
                case 3:
                    EliminarUsuario();
                    break;
                case 4:
                    MostrarUsuario();
                    break;
                case 5:
                    menuPrincipal();
                    break;
            }

        }

        public static void menuFamilia()
        {

            int op = -1;
            string opc;
            do
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(50, 3);
                Console.WriteLine("Fecha: {0}", DateTime.Now.ToString("dd/MM/yyyy"));
                Console.SetCursorPosition(50, 4);
                Console.WriteLine("Hora: {0}", DateTime.Now.ToString("H:mm:ss"));
                Console.SetCursorPosition(50, 5);
                Console.WriteLine("----------------------------------------");
                Console.SetCursorPosition(50, 6);
                Console.WriteLine("|          MENÚ FAMILIA PRODUCTO       |");
                Console.SetCursorPosition(50, 7);
                Console.WriteLine("----------------------------------------");
                Console.SetCursorPosition(50, 8);
                Console.WriteLine("|       1.- Ingresar Familia           |");
                Console.SetCursorPosition(50, 9);
                Console.WriteLine("|       2.- Modificar Familia          |");
                Console.SetCursorPosition(50, 10);
                Console.WriteLine("|       3.- Eliminar Familia           |");
                Console.SetCursorPosition(50, 11);
                Console.WriteLine("|       4.- Mostrar Familia            |");
                Console.SetCursorPosition(50, 12);
                Console.WriteLine("|       5.- Volver Menu Principal      |");
                Console.SetCursorPosition(50, 13);
                Console.WriteLine("----------------------------------------");
                Console.SetCursorPosition(50, 14);
                Console.WriteLine("            Ingrese Opcion [ ]          ");
                Console.SetCursorPosition(78, 14);
                opc = Console.ReadLine().Trim();

                if (numero(opc))
                {
                    op = int.Parse(opc);
                }
                else
                {
                    op = -1;
                }
                if (op < 0 || op > 5)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(50, 15);
                    Console.WriteLine("Opción Invalida!!!!!!");
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(50, 15);
                    Console.WriteLine("                     ");
                }
            } while (op < 0 || op > 5);

            switch (op)
            {

                case 1:
                    IngresarFamilia();
                    break;
                case 2:
                    ModificarFamilia();
                    break;
                case 3:
                    EliminarFamilia();
                    break;
                case 4:
                    MostrarFamilia();
                    break;
                case 5:
                    menuPrincipal();
                    break;
            }

        }

        public static void menuProducto()
        {

            int op = -1;
            string opc;
            do
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.SetCursorPosition(50, 3);
                Console.WriteLine("Fecha: {0}", DateTime.Now.ToString("dd/MM/yyyy"));
                Console.SetCursorPosition(50, 4);
                Console.WriteLine("Hora: {0}", DateTime.Now.ToString("H:mm:ss"));
                Console.SetCursorPosition(50, 5);
                Console.WriteLine("----------------------------------");
                Console.SetCursorPosition(50, 6);
                Console.WriteLine("|          MENÚ PRODUCTO         |");
                Console.SetCursorPosition(50, 7);
                Console.WriteLine("----------------------------------");
                Console.SetCursorPosition(50, 8);
                Console.WriteLine("|    1.- Ingresar Producto       |");
                Console.SetCursorPosition(50, 9);
                Console.WriteLine("|    2.- Modificar Producto      |");
                Console.SetCursorPosition(50, 10);
                Console.WriteLine("|    3.- Eliminar Producto       |");
                Console.SetCursorPosition(50, 11);
                Console.WriteLine("|    4.- Mostrar Producto        |");
                Console.SetCursorPosition(50, 12);
                Console.WriteLine("|    5.- Volver Menú Principal   |");
                Console.SetCursorPosition(50, 13);
                Console.WriteLine("----------------------------------");
                Console.SetCursorPosition(50, 14);
                Console.WriteLine("        Ingrese Opción [ ]        ");
                Console.SetCursorPosition(74, 14);
                opc = Console.ReadLine().Trim();

                if (numero(opc))
                {
                    op = int.Parse(opc);
                }
                else
                {
                    op = -1;
                }
                if (op < 0 || op > 5)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(50, 15);
                    Console.WriteLine("¡Opción Inválida!");
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(50, 15);
                    Console.WriteLine("                     ");
                }
            } while (op < 0 || op > 5);

            switch (op)
            {

                case 1:
                    IngresarProducto();
                    break;
                case 2:
                    ModificarProducto();
                    break;
                case 3:
                    EliminarProducto();
                    break;
                case 4:
                    MostrarProducto();
                    break;
                case 5:
                    menuPrincipal();
                    break;
            }

        }

        private static void IngresarUsuario()
        {

            Console.Clear();
            string rut, nombre, appaterno, apmaterno, usu, clave, estado;

            do
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.SetCursorPosition(40, 3);
                Console.WriteLine("--------------------------------------------");
                Console.SetCursorPosition(40, 4);
                Console.WriteLine("        INGRESO DATOS DEL USUARIO           ");
                Console.SetCursorPosition(40, 5);
                Console.WriteLine("--------------------------------------------");
                Console.SetCursorPosition(40, 7);
                Console.WriteLine("INGRESE RUT:");
                Console.SetCursorPosition(40, 8);
                rut = Console.ReadLine().Trim();
                if (!validaRut(rut))
                {
                    Console.SetCursorPosition(40, 8);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("RUT INVÁLIDO");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.ReadLine();
                }
            } while (!validaRut(rut));
            do
            {
                Console.SetCursorPosition(40, 10);
                Console.WriteLine("INGRESE NOMBRE:");
                Console.SetCursorPosition(40, 11);
                nombre = Console.ReadLine().Trim();
            } while (nombre.Equals(""));
            do
            {
                Console.SetCursorPosition(40, 13);
                Console.WriteLine("INGRESE APELLIDO PATERNO:");
                Console.SetCursorPosition(40, 14);
                appaterno = Console.ReadLine().Trim();
            } while (appaterno.Equals(""));
            do
            {
                Console.SetCursorPosition(40, 16);
                Console.WriteLine("INGRESE APELLIDO MATERNO:");
                Console.SetCursorPosition(40, 17);
                apmaterno = Console.ReadLine().Trim();
            } while (apmaterno.Equals(""));
            do
            {
                Console.SetCursorPosition(40, 19);
                Console.WriteLine("INGRESE USUARIO:");
                Console.SetCursorPosition(40, 20);
                usu = Console.ReadLine().Trim();
            } while (usu.Equals(""));
            do
            {
                Console.SetCursorPosition(40, 22);
                Console.WriteLine("INGRESE CLAVE:");
                Console.SetCursorPosition(40, 23);
                clave = Console.ReadLine().Trim();
            } while (clave.Equals(""));

            string claveMd5 = GetMD5Hash(clave);
            int esta, tipou;
            string tipo;
            do
            {
                Console.SetCursorPosition(40, 25);
                Console.WriteLine("INGRESE ESTADO: [1] ACTIVO | [0] INACTIVO");
                Console.SetCursorPosition(40, 26);
                estado = Console.ReadLine().Trim();
                int.TryParse(estado, out esta);
            } while (esta < 0 || esta > 1 || estado.Equals("") || !numero(estado));

            Usuario u = new Usuario(rut, nombre, appaterno, apmaterno, usu, clave, esta);

            do
            {
                Console.SetCursorPosition(40, 28);
                Console.WriteLine("INGRESE TIPO DE USUARIO: [1] ADMINISTRADOR | [2] BODEGUERO | [3] USUARIO");
                Console.SetCursorPosition(40, 29);
                tipo = Console.ReadLine().Trim();
                int.TryParse(tipo, out tipou);
            } while (tipou < 1 || tipou > 3 || tipo.Equals("") || !numero(tipo));

            if (tipou == 1)
            {
                u.TipoUsuario = GestorUsuario.TIPOADM;
            }
            else if (tipou == 2)
            {
                u.TipoUsuario = GestorUsuario.TIPOBOD;
            }
            else
            {
                u.TipoUsuario = GestorUsuario.TIPOUSU;
            }

            string usuario = rut + ";" + nombre + ";" + appaterno + ";" + apmaterno + ";" + usu + ";" + claveMd5 + ";" + esta + ";" + u.TipoUsuario.nombreTipo + ";" + u.TipoUsuario.codigoTipo;
            using (StreamWriter sw = File.AppendText(directorio))
            {
                sw.WriteLine(usuario);
                sw.Close();
            }

            Console.ReadLine();
            menuUsuario();
        }

        public static void ModificarUsuario()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Clear();
            StreamReader Archivo;
            String filename = directorio;
            Archivo = File.OpenText(filename);
            string linea;
            int cont = 1;
            int fila = 8;

            Console.SetCursorPosition(45, 5);
            Console.WriteLine(" =====================================");
            Console.SetCursorPosition(45, 6);
            Console.WriteLine("  LISTADO DE USUARIOS PARA MODIFICAR  ");
            Console.SetCursorPosition(45, 7);
            Console.WriteLine("=====================================");
            do
            {
                linea = Archivo.ReadLine();
                if (linea != null)
                {
                    string[] datos = linea.Split(";");
                    Console.SetCursorPosition(35, fila);
                    Console.WriteLine("{0}.- {1} - {2} - {3} - {4} - {5} - {6} - {7}", cont, datos[0], datos[1], datos[2], datos[3], datos[4], datos[6], datos[7] + " ");
                    fila++;
                    cont++;
                }
            } while (linea != null);
            Console.SetCursorPosition(45, fila);
            Console.WriteLine("=====================================");
            Archivo.Close();

            String modificar;
            int modi;
            do
            {
                Console.SetCursorPosition(35, 22);
                Console.WriteLine("INDIQUE EL NUMERO DE USUARIO QUE DESEA MODIFICAR [   ]");
                Console.SetCursorPosition(85, 22);
                modificar = Console.ReadLine().Trim();
                int.TryParse(modificar, out modi);
            } while (modi <= 0 || modi > cont || !numero(modificar));

            Console.Clear();
            string rut, nombre, appaterno, apmaterno, usu, clave, estado;


            do
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.SetCursorPosition(40, 3);
                Console.WriteLine("--------------------------------------------");
                Console.SetCursorPosition(40, 4);
                Console.WriteLine("        INGRESO DATOS DEL USUARIO           ");
                Console.SetCursorPosition(40, 5);
                Console.WriteLine("--------------------------------------------");
                Console.SetCursorPosition(40, 7);
                Console.WriteLine("INGRESE RUT:");
                Console.SetCursorPosition(40, 8);
                rut = Console.ReadLine().Trim();
                if (!validaRut(rut))
                {
                    Console.SetCursorPosition(40, 8);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("RUT INVALIDO");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.ReadLine();
                }
            } while (!validaRut(rut));
            do
            {
                Console.SetCursorPosition(40, 10);
                Console.WriteLine("INGRESE NOMBRE:");
                Console.SetCursorPosition(40, 11);
                nombre = Console.ReadLine().Trim();
            } while (nombre.Equals(""));
            do
            {
                Console.SetCursorPosition(40, 13);
                Console.WriteLine("INGRESE APELLIDO PATERNO:");
                Console.SetCursorPosition(40, 14);
                appaterno = Console.ReadLine().Trim();
            } while (appaterno.Equals(""));
            do
            {
                Console.SetCursorPosition(40, 16);
                Console.WriteLine("INGRESE APELLIDO MATERNO:");
                Console.SetCursorPosition(40, 17);
                apmaterno = Console.ReadLine().Trim();
            } while (apmaterno.Equals(""));
            do
            {
                Console.SetCursorPosition(40, 19);
                Console.WriteLine("INGRESE USUARIO:");
                Console.SetCursorPosition(40, 20);
                usu = Console.ReadLine().Trim();
            } while (usu.Equals(""));
            do
            {
                Console.SetCursorPosition(40, 22);
                Console.WriteLine("INGRESE CLAVE:");
                Console.SetCursorPosition(40, 23);
                clave = Console.ReadLine().Trim();
            } while (clave.Equals(""));
            string claveMd5 = GetMD5Hash(clave);
            int esta, tipou;
            string tipo;
            do
            {
                Console.SetCursorPosition(40, 25);
                Console.WriteLine("INGRESE ESTADO: [1] ACTIVO | [0] INACTIVO");
                Console.SetCursorPosition(40, 26);
                estado = Console.ReadLine().Trim();
                int.TryParse(estado, out esta);
            } while (esta < 0 || esta > 1 || estado.Equals("") || !numero(estado));

            Usuario u = new Usuario(rut, nombre, appaterno, apmaterno, usu, clave, esta);

            do
            {
                Console.SetCursorPosition(40, 28);
                Console.WriteLine("INGRESE TIPO DE USUARIO: [1] ADMINISTRADOR | [2] BODEGUERO | [3] USUARIO");
                Console.SetCursorPosition(40, 29);
                tipo = Console.ReadLine().Trim();
                int.TryParse(tipo, out tipou);
            } while (tipou < 1 || tipou > 3 || tipo.Equals("") || !numero(tipo));

            if (tipou == 1)
            {
                u.TipoUsuario = GestorUsuario.TIPOADM;
            }
            else if (tipou == 2)
            {
                u.TipoUsuario = GestorUsuario.TIPOBOD;
            }
            else
            {
                u.TipoUsuario = GestorUsuario.TIPOUSU;

            }

            string usuario = rut + ";" + nombre + ";" + appaterno + ";" + apmaterno + ";" + usu + ";" + claveMd5 + ";" + esta + ";" + u.TipoUsuario.nombreTipo + ";" + u.TipoUsuario.codigoTipo;
            lineChanger(usuario, filename, modi);
            MostrarUsuario();
        }

        public static void EliminarUsuario()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Clear();
            StreamReader Archivo;
            Archivo = File.OpenText(directorio);
            string linea;
            int cont = 1;
            int fila = 8;

            Console.SetCursorPosition(45, 5);
            Console.WriteLine(" =====================================");
            Console.SetCursorPosition(45, 6);
            Console.WriteLine("  LISTADO DE USUARIOS PARA ELIMINAR  ");
            Console.SetCursorPosition(45, 7);
            Console.WriteLine("=====================================");
            do
            {
                linea = Archivo.ReadLine();
                if (linea != null)
                {
                    string[] datos = linea.Split(";");
                    Console.SetCursorPosition(35, fila);
                    Console.WriteLine("{0}.- {1} - {2} - {3} - {4} - {5} - {6} - {7}", cont, datos[0], datos[1], datos[2], datos[3], datos[4], datos[6], datos[7] + " ");
                    fila++;
                    cont++;
                }
            } while (linea != null);
            Console.SetCursorPosition(45, fila);
            Console.WriteLine("=====================================");
            Archivo.Close();
            String eliminar;
            int eli;
            do
            {
                Console.SetCursorPosition(35, 22);
                Console.WriteLine("INDIQUE EL NUMERO DE USUARIO QUE DESEA ELIMINAR [   ]");
                Console.SetCursorPosition(85, 22);
                eliminar = Console.ReadLine().Trim();
                int.TryParse(eliminar, out eli);
            } while (eli <= 0 || eli > cont || eliminar.Equals("") || !numero(eliminar));


            int contelim = 1;
            StreamWriter TEMPORAL = new StreamWriter(tempFile, true);
            Archivo = File.OpenText(directorio);
            do
            {
                linea = Archivo.ReadLine();
                if ((contelim != eli) && (linea != null))
                {
                    TEMPORAL.WriteLine(linea, Encoding.UTF8);
                }
                contelim++;
            } while (linea != null);
            Archivo.Close();
            TEMPORAL.Close();


            try
            {
                File.Delete(directorio);
            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine(e.Message);
                return;
            }

            File.Move(tempFile, directorio);

            MostrarUsuario();
        }

        private static void MostrarUsuario()
        {

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Clear();
            StreamReader Archivo;
            Archivo = File.OpenText(directorio);

            string linea;
            int cont = 1;
            int fila = 8;
            Console.SetCursorPosition(35, 5);
            Console.WriteLine("=====================================================");
            Console.SetCursorPosition(35, 6);
            Console.WriteLine("                  LISTADO DE USUARIOS                ");
            Console.SetCursorPosition(35, 7);
            Console.WriteLine("=====================================================");
            do
            {
                linea = Archivo.ReadLine();
                if (linea != null)
                {

                    string[] datos = linea.Split(";");
                    Console.SetCursorPosition(35, fila);
                    Console.WriteLine("{0}.- {1} - {2} - {3} - {4} - {5} - {6} - {7}", cont, datos[0], datos[1], datos[2], datos[3], datos[4], datos[6], datos[7] + " ");
                    fila++;
                    cont++;

                }

            } while (linea != null);
            Console.SetCursorPosition(35, fila);
            Console.WriteLine("======================================================");
            Archivo.Close();
            Console.ReadLine();
            menuUsuario();
        }

        static void lineChanger(string newText, string fileName, int line_to_edit)
        {
            string[] arrLine = File.ReadAllLines(fileName);
            arrLine[line_to_edit - 1] = newText;
            File.WriteAllLines(fileName, arrLine);
        }

        private static void IngresarFamilia()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Clear();
            string nombre, estado;
            Console.SetCursorPosition(40, 3);
            Console.WriteLine("--------------------------------------------");
            Console.SetCursorPosition(40, 4);
            Console.WriteLine("  INGRESO DATOS DE LA FAMILIA DE PRODUCTOS  ");
            Console.SetCursorPosition(40, 5);
            Console.WriteLine("--------------------------------------------");

            do
            {
                Console.SetCursorPosition(40, 6);
                Console.WriteLine("INGRESE NOMBRE:");
                Console.SetCursorPosition(40, 7);
                nombre = Console.ReadLine().Trim();
            } while (nombre.Equals(""));
            int esta;
            do
            {
                Console.SetCursorPosition(40, 8);
                Console.WriteLine("INGRESE ESTADO: [1] ACTIVO | [0] INACTIVO");
                Console.SetCursorPosition(40, 9);
                estado = Console.ReadLine().Trim();
                int.TryParse(estado, out esta);
            } while (esta < 0 || esta > 1 || estado.Equals("") || !numero(estado));

            string familia = nombre + ";" + esta;
            using (StreamWriter sw = File.AppendText(directoriofamilia))
            {
                sw.WriteLine(familia);
                sw.Close();
            }
            Console.ReadLine();
            MostrarFamilia();
        }

        private static void ModificarFamilia()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Clear();
            StreamReader Archivo;
            String filename = directoriofamilia;
            Archivo = File.OpenText(filename);
            string linea, nombre, estado;
            int cont = 1;
            int fila = 8;
            Console.SetCursorPosition(40, 5);
            Console.WriteLine("======================================");
            Console.SetCursorPosition(40, 6);
            Console.WriteLine("  LISTADO DE FAMILIAS PARA MODIFICAR  ");
            Console.SetCursorPosition(40, 7);
            Console.WriteLine("======================================");

            do
            {
                linea = Archivo.ReadLine();
                if (linea != null)
                {
                    string[] datos = linea.Split(";");
                    Console.SetCursorPosition(45, fila);
                    Console.WriteLine("{0}.- {1} - {2}", cont, datos[0], datos[1] + " ");
                    fila++;
                    cont++;
                }
            } while (linea != null);
            Console.SetCursorPosition(45, fila);
            Console.WriteLine("=====================================");

            Archivo.Close();
            int modi;
            string modificar;
            do
            {
                Console.SetCursorPosition(35, 22);
                Console.WriteLine("INDIQUE EL NÚMERO DE FAMILIA QUE DESEA MODIFICAR [   ]");
                Console.SetCursorPosition(85, 22);
                modificar = Console.ReadLine().Trim();
                int.TryParse(modificar, out modi);
            } while (modi <= 0 || modi > cont || modificar.Equals("") || !numero(modificar));
            Console.Clear();

            Console.SetCursorPosition(40, 3);
            Console.WriteLine("--------------------------------------------");
            Console.SetCursorPosition(40, 4);
            Console.WriteLine("  INGRESO DATOS DE LA FAMILIA DE PRODUCTOS  ");
            Console.SetCursorPosition(40, 5);
            Console.WriteLine("--------------------------------------------");

            do
            {
                Console.SetCursorPosition(40, 6);
                Console.WriteLine("INGRESE NOMBRE:");
                Console.SetCursorPosition(40, 7);
                nombre = Console.ReadLine().Trim();
            } while (nombre.Equals(""));
            int esta;
            do
            {
                Console.SetCursorPosition(40, 8);
                Console.WriteLine("INGRESE ESTADO: [1] ACTIVO | [0] INACTIVO");
                Console.SetCursorPosition(40, 9);
                estado = Console.ReadLine().Trim();
                int.TryParse(estado, out esta);
            } while (esta < 0 || esta > 1 || estado.Equals("") || !numero(estado));

            string familia = nombre + ";" + esta;
            lineChanger(familia, filename, modi);
            ModificarFamilia();

        }


        private static void EliminarFamilia()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Clear();
            StreamReader Archivo;
            Archivo = File.OpenText(directoriofamilia);
            string linea, estado;
            int cont = 1;
            int fila = 8;
            Console.SetCursorPosition(45, 5);
            Console.WriteLine("=====================================");
            Console.SetCursorPosition(45, 6);
            Console.WriteLine("  LISTADO DE FAMILIA PARA ELIMINAR   ");
            Console.SetCursorPosition(45, 7);
            Console.WriteLine("=====================================");

            do
            {
                linea = Archivo.ReadLine();
                if (linea != null)
                {
                    string[] datos = linea.Split(";");
                    Console.SetCursorPosition(45, fila);
                    Console.WriteLine("{0}.- {1} - {2}", cont, datos[0], datos[1] + " ");
                    fila++;
                    cont++;
                }
            } while (linea != null);

            Console.SetCursorPosition(45, fila);
            Console.WriteLine("=====================================");
            Archivo.Close();
            String eliminar;
            int eli;

            do
            {
                Console.SetCursorPosition(35, 22);
                Console.WriteLine("INDIQUE EL NÚMERO DE FAMILIA QUE DESEA ELIMINAR [   ]");
                Console.SetCursorPosition(85, 22);
                eliminar = Console.ReadLine().Trim();
                int.TryParse(eliminar, out eli);
            } while (eli <= 0 || eli > cont || eliminar.Equals("") || !numero(eliminar));

            int contelim = 1;
            StreamWriter TEMPORAL = new StreamWriter(tempFileFamilia, true);
            Archivo = File.OpenText(directoriofamilia);
            do
            {
                linea = Archivo.ReadLine();
                if ((contelim != eli) && (linea != null))
                {
                    TEMPORAL.WriteLine(linea, Encoding.UTF8);
                }
                contelim++;
            } while (linea != null);
            Archivo.Close();
            TEMPORAL.Close();

            try
            {
                File.Delete(directoriofamilia);
            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine(e.Message);
                return;
            }

            File.Move(tempFileFamilia, directoriofamilia);
            MostrarFamilia();
        }

        private static void MostrarFamilia()
        {

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Console.SetCursorPosition(35, 5);
            Console.WriteLine("=====================================================");
            Console.SetCursorPosition(35, 6);
            Console.WriteLine("           LISTADO DE FAMILIAS DE PRODUCTOS          ");
            Console.SetCursorPosition(35, 7);
            Console.WriteLine("=====================================================");
            StreamReader Archivo;
            Archivo = File.OpenText(directoriofamilia);
            string linea, estado;
            int cont = 1;
            int fila = 9;
            do
            {
                linea = Archivo.ReadLine();
                if (linea != null)
                {

                    string[] datos = linea.Split(";");
                    Console.SetCursorPosition(35, fila);
                    if (datos[1] == "1")
                    {
                        estado = "Activo";
                    }
                    else
                    {
                        estado = "Inactivo";
                    }
                    Console.WriteLine("{0}.- {1} - {2} ", cont, datos[0], estado + " ");
                    fila++;
                    cont++;

                }

            } while (linea != null);
            Console.SetCursorPosition(35, fila);
            Console.WriteLine("======================================================");
            Archivo.Close();
            Console.ReadLine();
            menuFamilia();
        }

        private static void IngresarProducto()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Clear();
            string nombre, modelo, descripcion, stock, stockminimo, precio, consumible, estado;

            Console.SetCursorPosition(40, 3);
            Console.WriteLine("--------------------------------------------");
            Console.SetCursorPosition(40, 4);
            Console.WriteLine("         INGRESO DATOS DEL PRODUCTO         ");
            Console.SetCursorPosition(40, 5);
            Console.WriteLine("--------------------------------------------");

            do
            {
                Console.SetCursorPosition(40, 6);
                Console.WriteLine("INGRESE NOMBRE:");
                Console.SetCursorPosition(40, 7);
                nombre = Console.ReadLine().Trim();
            } while (nombre.Equals(""));

            do
            {
                Console.SetCursorPosition(40, 8);
                Console.WriteLine("INGRESE MODELO:");
                Console.SetCursorPosition(40, 9);
                modelo = Console.ReadLine().Trim();
            } while (modelo.Equals(""));

            do
            {
                Console.SetCursorPosition(40, 10);
                Console.WriteLine("INGRESE DESCRIPCIÓN:");
                Console.SetCursorPosition(40, 11);
                descripcion = Console.ReadLine().Trim();
            } while (descripcion.Equals(""));
            int stockn;
            do
            {
                Console.SetCursorPosition(40, 12);
                Console.WriteLine("INGRESE STOCK:");
                Console.SetCursorPosition(40, 13);
                stock = Console.ReadLine().Trim();
                int.TryParse(stock, out stockn);
            } while (stock.Equals("") || stockn < 0 || !numero(stock));
            int stockMn;
            do
            {
                Console.SetCursorPosition(40, 14);
                Console.WriteLine("INGRESE STOCK MÍNIMO:");
                Console.SetCursorPosition(40, 15);
                stockminimo = Console.ReadLine().Trim();
                int.TryParse(stockminimo, out stockMn);
            } while (stockminimo.Equals("") || stockMn < 0 || !numero(stockminimo));

            int prec;
            do
            {
                Console.SetCursorPosition(40, 16);
                Console.WriteLine("INGRESE PRECIO:");
                Console.SetCursorPosition(40, 17);
                precio = Console.ReadLine().Trim();
                int.TryParse(precio, out prec);
            } while (precio.Equals("") || prec < 0 || !numero(precio));

            int consu;
            do
            {
                Console.SetCursorPosition(40, 18);
                Console.WriteLine("¿ES CONSUMIBLE?: [1] SÍ | [0] NO");
                Console.SetCursorPosition(40, 19);
                consumible = Console.ReadLine().Trim();
                int.TryParse(consumible, out consu);
            } while (consu < 0 || consu > 1 || consumible.Equals("") || !numero(consumible));

            int esta;
            do
            {
                Console.SetCursorPosition(40, 20);
                Console.WriteLine("INGRESE ESTADO: [1] ACTIVO | [0] INACTIVO");
                Console.SetCursorPosition(40, 21);
                estado = Console.ReadLine().Trim();
                int.TryParse(estado, out esta);
            } while (esta < 0 || esta > 1 || estado.Equals("") || !numero(estado));

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(35, 22);
            Console.WriteLine("=====================================================");
            Console.SetCursorPosition(35, 23);
            Console.WriteLine("           LISTADO DE FAMILIAS DE PRODUCTOS          ");
            Console.SetCursorPosition(35, 24);
            Console.WriteLine("=====================================================");
            StreamReader Archivo;
            Archivo = File.OpenText(directoriofamilia);
            string linea, estF;
            int cont = 1;
            int fila = 25;
            do
            {
                linea = Archivo.ReadLine();
                if (linea != null)
                {

                    string[] datosF = linea.Split(";");
                    Console.SetCursorPosition(35, fila);

                    Console.WriteLine("{0}.- {1}", cont, datosF[0] + " ");
                    fila++;
                    cont++;
                }
            } while (linea != null);
            Console.SetCursorPosition(35, fila);
            Console.WriteLine("======================================================");
            Archivo.Close();

            String sel;
            int op;
            do
            {
                Console.SetCursorPosition(35, fila + 1);
                Console.WriteLine("INDIQUE LA FAMILIA DEL PRODUCTO [   ]");
                Console.SetCursorPosition(69, fila + 1);
                sel = Console.ReadLine().Trim();
                int.TryParse(sel, out op);
            } while (op <= 0 || op > cont || !numero(sel));

            Archivo = File.OpenText(directoriofamilia);


            string nomFam = "";
            for (int i = 0; i < op; i++)
            {
                linea = Archivo.ReadLine();
                string[] fam = linea.Split(";");
                if (linea != null)
                {
                    nomFam = fam[0];
                }
            }
            Archivo.Close();
            string producto = nombre + ";" + modelo + ";" + descripcion + ";" + stockn + ";" + stockMn + ";" + prec + ";" + consu + ";" + esta + ";" + nomFam;
            using (StreamWriter sw = File.AppendText(directorioProd))
            {
                sw.WriteLine(producto);
                sw.Close();
            }
            Console.ReadLine();
            MostrarProducto();
        }

        public static void ModificarProducto()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Clear();
            StreamReader Archivo;
            String filename = directorioProd;
            Archivo = File.OpenText(filename);
            string linea;
            int cont = 1;
            int fila = 8;

            Console.SetCursorPosition(45, 5);
            Console.WriteLine("=====================================");
            Console.SetCursorPosition(45, 6);
            Console.WriteLine(" LISTADO DE PRODUCTOS PARA MODIFICAR ");
            Console.SetCursorPosition(45, 7);
            Console.WriteLine("=====================================");
            do
            {
                linea = Archivo.ReadLine();
                if (linea != null)
                {
                    string[] datos = linea.Split(";");
                    Console.SetCursorPosition(12, fila);
                    Console.WriteLine("{0}.- {1} {2} - {3} - Hay: {4} - Mín: {5} - Precio: {6} - Familia: {7}", cont, datos[0], datos[1], datos[2], datos[3], datos[4], datos[5], datos[8] + " ");
                    fila++;
                    cont++;
                }
            } while (linea != null);
            Console.SetCursorPosition(45, fila);
            Console.WriteLine("=====================================");
            Archivo.Close();

            String modificar;
            int modi;
            do
            {
                Console.SetCursorPosition(35, 22);
                Console.WriteLine("INDIQUE EL NÚMERO DEL PRODUCTO QUE DESEA MODIFICAR [    ]");
                Console.SetCursorPosition(88, 22);
                modificar = Console.ReadLine().Trim();
                int.TryParse(modificar, out modi);
            } while (modi <= 0 || modi > cont || !numero(modificar));

            Console.Clear();
            string nombre, modelo, descripcion, stock, stockminimo, precio, consumible, estado;


            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(40, 3);
            Console.WriteLine("--------------------------------------------");
            Console.SetCursorPosition(40, 4);
            Console.WriteLine("        INGRESO DATOS DEL PRODUCTO          ");
            Console.SetCursorPosition(40, 5);
            Console.WriteLine("--------------------------------------------");
            Console.SetCursorPosition(40, 7);
            do
            {
                Console.SetCursorPosition(40, 6);
                Console.WriteLine("INGRESE NOMBRE:");
                Console.SetCursorPosition(40, 7);
                nombre = Console.ReadLine().Trim();
            } while (nombre.Equals(""));

            do
            {
                Console.SetCursorPosition(40, 8);
                Console.WriteLine("INGRESE MODELO:");
                Console.SetCursorPosition(40, 9);
                modelo = Console.ReadLine().Trim();
            } while (modelo.Equals(""));

            do
            {
                Console.SetCursorPosition(40, 10);
                Console.WriteLine("INGRESE DESCRIPCIÓN:");
                Console.SetCursorPosition(40, 11);
                descripcion = Console.ReadLine().Trim();
            } while (descripcion.Equals(""));
            int stockn;
            do
            {
                Console.SetCursorPosition(40, 12);
                Console.WriteLine("INGRESE STOCK:");
                Console.SetCursorPosition(40, 13);
                stock = Console.ReadLine().Trim();
                int.TryParse(stock, out stockn);
            } while (stock.Equals("") || stockn < 0 || !numero(stock));
            int stockMn;
            do
            {
                Console.SetCursorPosition(40, 14);
                Console.WriteLine("INGRESE STOCK MÍNIMO:");
                Console.SetCursorPosition(40, 15);
                stockminimo = Console.ReadLine().Trim();
                int.TryParse(stockminimo, out stockMn);
            } while (stockminimo.Equals("") || stockMn < 0 || !numero(stockminimo));

            int prec;
            do
            {
                Console.SetCursorPosition(40, 16);
                Console.WriteLine("INGRESE PRECIO:");
                Console.SetCursorPosition(40, 17);
                precio = Console.ReadLine().Trim();
                int.TryParse(precio, out prec);
            } while (precio.Equals("") || prec < 0 || !numero(precio));

            int consu;
            do
            {
                Console.SetCursorPosition(40, 18);
                Console.WriteLine("¿ES CONSUMIBLE?: [1] SÍ | [0] NO");
                Console.SetCursorPosition(40, 19);
                consumible = Console.ReadLine().Trim();
                int.TryParse(consumible, out consu);
            } while (consu < 0 || consu > 1 || consumible.Equals("") || !numero(consumible));

            int esta;
            do
            {
                Console.SetCursorPosition(40, 20);
                Console.WriteLine("INGRESE ESTADO: [1] ACTIVO | [0] INACTIVO");
                Console.SetCursorPosition(40, 21);
                estado = Console.ReadLine().Trim();
                int.TryParse(estado, out esta);
            } while (esta < 0 || esta > 1 || estado.Equals("") || !numero(estado));

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(35, 22);
            Console.WriteLine("=====================================================");
            Console.SetCursorPosition(35, 23);
            Console.WriteLine("           LISTADO DE FAMILIAS DE PRODUCTOS          ");
            Console.SetCursorPosition(35, 24);
            Console.WriteLine("=====================================================");

            Archivo = File.OpenText(directoriofamilia);
            int cont2 = 1;
            int fila2 = 25;
            do
            {
                linea = Archivo.ReadLine();
                if (linea != null)
                {

                    string[] datosF = linea.Split(";");
                    Console.SetCursorPosition(35, fila2);

                    Console.WriteLine("{0}.- {1}", cont2, datosF[0] + " ");
                    fila2++;
                    cont2++;
                }
            } while (linea != null);
            Console.SetCursorPosition(35, fila2);
            Console.WriteLine("======================================================");
            Archivo.Close();

            String sel;
            int op;
            do
            {
                Console.SetCursorPosition(35, fila2 + 1);
                Console.WriteLine("INDIQUE LA FAMILIA DEL PRODUCTO [   ]");
                Console.SetCursorPosition(69, fila2 + 1);
                sel = Console.ReadLine().Trim();
                int.TryParse(sel, out op);
            } while (op <= 0 || op > cont || !numero(sel));

            Archivo = File.OpenText(directoriofamilia);


            string nomFam = "";
            for (int i = 0; i < op; i++)
            {
                linea = Archivo.ReadLine();
                string[] fam = linea.Split(";");
                if (linea != null)
                {
                    nomFam = fam[0];
                }
            }
            Archivo.Close();
            string producto = nombre + ";" + modelo + ";" + descripcion + ";" + stockn + ";" + stockMn + ";" + prec + ";" + consu + ";" + esta + ";" + nomFam;
            lineChanger(producto, filename, modi);
            MostrarProducto();
        }

        public static void EliminarProducto()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Clear();
            StreamReader Archivo;
            Archivo = File.OpenText(directorioProd);
            string linea;
            int cont = 1;
            int fila = 8;

            Console.SetCursorPosition(45, 5);
            Console.WriteLine("=====================================");
            Console.SetCursorPosition(45, 6);
            Console.WriteLine(" LISTADO DE PRODUCTOS PARA ELIMINAR  ");
            Console.SetCursorPosition(45, 7);
            Console.WriteLine("=====================================");
            do
            {
                linea = Archivo.ReadLine();
                if (linea != null)
                {
                    string[] datos = linea.Split(";");
                    Console.SetCursorPosition(12, fila);
                    Console.WriteLine("{0}.- {1} {2} - {3} - Hay: {4} - Mín: {5} - Precio: {6} - Familia: {7}", cont, datos[0], datos[1], datos[2], datos[3], datos[4], datos[5], datos[8] + " ");
                    fila++;
                    cont++;
                }
            } while (linea != null);
            Console.SetCursorPosition(45, fila);
            Console.WriteLine("=====================================");
            Archivo.Close();
            String eliminar;
            int eli;
            do
            {
                Console.SetCursorPosition(35, 22);
                Console.WriteLine("INDIQUE EL NÚMERO DEL PRODUCTO QUE DESEA ELIMINAR [   ]");
                Console.SetCursorPosition(87, 22);
                eliminar = Console.ReadLine().Trim();
                int.TryParse(eliminar, out eli);
            } while (eli <= 0 || eli > cont || eliminar.Equals("") || !numero(eliminar));


            int contelim = 1;
            StreamWriter TEMPORAL = new StreamWriter(tempFileProd, true);
            Archivo = File.OpenText(directorioProd);
            do
            {
                linea = Archivo.ReadLine();
                if ((contelim != eli) && (linea != null))
                {
                    TEMPORAL.WriteLine(linea, Encoding.UTF8);
                }
                contelim++;
            } while (linea != null);

            Archivo.Close();
            TEMPORAL.Close();

            try
            {
                File.Delete(directorioProd);
            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine(e.Message);
                return;
            }

            File.Move(tempFileProd, directorioProd);

            MostrarProducto();
        }

        private static void MostrarProducto()
        {

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            StreamReader Archivo;
            Archivo = File.OpenText(directorioProd);

            string linea;
            int cont = 1;
            int fila = 8;
            Console.SetCursorPosition(35, 5);
            Console.WriteLine("=====================================================");
            Console.SetCursorPosition(35, 6);
            Console.WriteLine("                  LISTADO DE PRODUCTOS               ");
            Console.SetCursorPosition(35, 7);
            Console.WriteLine("=====================================================");
            do
            {
                linea = Archivo.ReadLine();
                if (linea != null)
                {

                    string[] datos = linea.Split(";");
                    Console.SetCursorPosition(12, fila);
                    Console.WriteLine("{0}.- {1} {2} - {3} - Hay: {4} - Mín: {5} - Precio: {6} - Familia: {7}", cont, datos[0], datos[1], datos[2], datos[3], datos[4], datos[5], datos[8] + " ");
                    fila++;
                    cont++;

                }

            } while (linea != null);
            Console.SetCursorPosition(35, fila);
            Console.WriteLine("======================================================");
            Archivo.Close();
            Console.ReadLine();
            menuProducto();
        }

        public static bool Logear(string u, string p)
        {
            p = GetMD5Hash(p);
            Console.WriteLine(p);
            Console.Clear();
            string linea;
            StreamReader Archivo;
            bool result = false;
            Archivo = File.OpenText(directorio);
            do
            {
                linea = Archivo.ReadLine();
                if (linea != null)
                {
                    string[] datos = linea.Split(";");
                    if (string.Equals(u, datos[4].Trim()) && string.Equals(p, datos[5].Trim()))
                    {
                        result = true;
                        break;
                    }
                }
            }
            while (linea != null);
            Archivo.Close();
            return result;
        }

        public static bool validaRut(string rut)
        {
            bool validacion = false;
            try
            {
                rut = rut.ToUpper();
                rut = rut.Replace(".", "");
                rut = rut.Replace("-", "");
                int rutAux = int.Parse(rut.Substring(0, rut.Length - 1));
                char dv = char.Parse(rut.Substring(rut.Length - 1, 1));

                int m = 0, s = 1;
                for (; rutAux != 0; rutAux /= 10)
                {
                    s = (s + rutAux % 10 * (9 - m++ % 6)) % 11;
                }
                if (dv == (char)(s != 0 ? s + 47 : 75))
                {
                    validacion = true;
                }
            }
            catch (Exception)
            {
            }
            return validacion;
        }

        public static void MenuLogin()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(45, 5);
            Console.WriteLine("===================================");
            Console.SetCursorPosition(45, 6);
            Console.WriteLine("|      AUTENTICACIÓN SISTEMA      |");
            Console.SetCursorPosition(45, 7);
            Console.WriteLine("===================================");
            Console.SetCursorPosition(45, 8);
            Console.WriteLine("|                                 |");
            Console.SetCursorPosition(45, 9);
            Console.WriteLine("|   USUARIO    [              ]   |");
            Console.SetCursorPosition(45, 10);
            Console.WriteLine("|   CONTRASEÑA [              ]   |");
            Console.SetCursorPosition(45, 11);
            Console.WriteLine("|                                 |");
            Console.SetCursorPosition(45, 12);
            Console.WriteLine("===================================");
        }

        public static String GetMD5Hash(String input)
        {
            MD5CryptoServiceProvider x = new MD5CryptoServiceProvider();
            byte[] bs = System.Text.Encoding.UTF8.GetBytes(input);
            bs = x.ComputeHash(bs);
            System.Text.StringBuilder s = new System.Text.StringBuilder();
            foreach (byte b in bs)
            {
                s.Append(b.ToString("x2").ToLower());
            }
            String hash = s.ToString();
            return hash;
        }

        private static GestorUsuario usuarioDAL = new GestorUsuario();
        private static GestorProducto productooDAL = new GestorProducto();
        private static GestorFamilia familiaDAL = new GestorFamilia();
        private static string directorio = (@"C:\Users\balle\source\repos\Ferreteria\usuarios.txt");
        private static string tempFile = (@"C:\Users\balle\source\repos\Ferreteria\usuariostmp.txt");
        private static string directoriofamilia = (@"C:\Users\balle\source\repos\Ferreteria\familia.txt");
        private static string tempFileFamilia = (@"C:\Users\balle\source\repos\Ferreteria\familiatmp.txt");
        private static string directorioProd = (@"C:\Users\balle\source\repos\Ferreteria\productos.txt");
        private static string tempFileProd = (@"C:\Users\balle\source\repos\Ferreteria\productostmp.txt");


        static void Main(string[] args)
        {
            string usu;
            string pass;
            do
            {
                Console.Clear();
                ConsoleKeyInfo key;
                MenuLogin();
                pass = "";
                Console.SetCursorPosition(61, 9);
                usu = Console.ReadLine().Trim();
                Console.SetCursorPosition(61, 10);
                do
                {
                    key = Console.ReadKey(true);
                    if (key.Key != ConsoleKey.Backspace)
                    {
                        pass += key.KeyChar;
                        Console.Write("*");
                    }
                }
                while (key.Key != ConsoleKey.Enter);

                pass = pass.Trim();
            } while (!Logear(usu, pass));

            menuPrincipal();
        }
    }
}

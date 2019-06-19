using Libreria;
public delegate void DelegadoSueldo(Empleado e,float f);
public delegate void DelSueldo(EmpleadoMejorado e, EmpleadoSueldoArgs eArgs);
public enum EManejador
{
  LimiteSueldo,
  Log,
  Ambos
}

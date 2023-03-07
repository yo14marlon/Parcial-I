using Parcial.Entidades;

ClsUsuario loguearse = new ClsUsuario();
ClsVenta venta = new ClsVenta();


bool loguear = loguearse.ACCESO();

if(loguear)
{
    venta.COBRO();
}






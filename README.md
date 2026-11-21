# TrabajoFinal - Grupo2 - LUG26



Integrantes : 

Tomás Martelon
Fabricio Soza
Gonzalo Layño
Marina Celeste Oreskovic
Diego Alejandro Rodriguez Cabrera
Roberto Kopp


Descripción de cada entrega parcial:

Presentación y defensa del negocio: El mismo debe ser lo suficientemente complejo como para tener - al menos - tres tablas para persistir en una base de datos y algún tipo de relación entre todas
Presentación de la base de datos: Se debe desarrollar la base de datos, mostrando las tablas con todos sus campos completos, toda tabla debe tener claves primarias, los tipos de datos de cada columna deben ser correctos y se debe presentar algún tipo de relación entre alguna de las tablas a desarrollar
Presentación inicial de la solución: Realizada con arquitectura en capas, en este momento la aplicación no debe estar persistiendo información en la base de datos, pero sí debe tener toda su estructura, la mayoría de los formularios desarrollados y la mayoría de las reglas de negocio desarrolladas/ propuestas - En clase se explicará en qué consisten las reglas de negocio, en qué capa de nuestro sistema van a estar y qué complejidad se va a solicitar para la entrega de este trabajo.
Presentación parcial de la solución: vamos a tener todos los puntos anteriores desarrollados agregando que la aplicación se va a encontrar consultado y manipulando la base de datos creada
Presentación final y defensa: se presentará la aplicación completa funcionando en su totalidad, con manejo de transacciones de negocio (serán vistas en clase) y se realizará una defensa oral por parte del equipo
Adicionalmente el trabajo integrador debe ser entregado con la siguiente documentación en un documento:
Carátula y descripción del sistema
Diagrama de base de datos
Diagrama de clases
Manual de usuario



Se otorgarán puntos adicionales a aquellos equipos que utilicen herramientas adicionales para el trabajo en equipo tales como:

Git para la persistencia y seguimiento del código
Jira / Trello o apps similares para la gestión de tareas y equipos



## Cómo levantar el proyecto

1. Base de datos, una de dos opciones:
   - **Desde cero:** ejecutar `BD_TP_Grupo2.sql`. **Borra y vuelve a crear** la base `TP_LUG_G2` con datos de prueba.
   - **Conservando la base que ya tenés:** ejecutar `BD_Actualizacion.sql`. No borra datos: agrega la tabla `Usuario`, renombra la columna `Estado` de `Pedido` y le agrega `Id_Usuario`.
2. Revisar la cadena de conexión `TrabajoFinalDB` en `TrabajoFinal - Grupo2 - LUG26/App.config` (por defecto `localhost` con seguridad integrada; con SQL Express usar `localhost\SQLEXPRESS`).
3. Abrir `TrabajoFinal - Grupo2 - LUG26.slnx` en Visual Studio y ejecutar el proyecto `TrabajoFinal - Grupo2 - LUG26`.

Usuarios de prueba:

| Usuario  | Contraseña  | Rol           |
|----------|-------------|---------------|
| admin    | admin123    | administrador |
| vendedor | vendedor123 | vendedor      |

## Capas

`Entidad` → `Mapper` → `Dato` → `Negocio` → UI. La UI solo referencia a `Negocio` y `Entidad`.

La transacción de negocio es la confirmación del pedido: `PedidoBLL.ConfirmarPedido` valida y calcula, y `PedidoDAO.ConfirmarEnTransaccion` graba cabecera, detalle y descuento de stock en una sola `SqlTransaction`.

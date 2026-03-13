# CIBERINFRAESTRUCTURA
## Windows Forms
### Validador de Contraseñas

### Funcionalidades

1. Función Placeholder sin afección con futura conexión  con bases de datos.
2. Ocultar la contraseña mediante el cambio de caracteres por el uso de "*"
3. Funcion de validación de la contraseña con requisitos establecidos
4. Confirmacion del cumplimiento de los requisitos
5. Confirmacion de validación

#### Requisitos

Incorporar a la vista dos campos de texto y un botón que validen la estructura de una contraseña, la contraseña deberá exigir:

  1. Al menos una letra mayúscula
  2. Al menos una letra minúscula
  3. Al menos un símbolo
  4. Al menos un número

Si la contraseña ingresada corresponde a la regla solicitada, la siguiente validación comprobará que el segundo campo contenga el mismo texto
Una vez que esto suceda deberá aparecer un MESSAGE BOX que diga "La contraseña ha sido validada"

Un evento click en el botón, que envía el formulario y que retorna la validación.
Una expresión regular (Regex) que valide la regla propuesta.

#### Función Regex

La función principal consiste en la validación caracter a caracter de la contraseña mediante la función ValidarContrasena, la cual emplea la siguient función regular;

  string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$";

Gracias a este patron podemos identificar si la contraseña ingresada contiene;

1. (?=.*[a-z]) :       Al menos una mayúscula
2. (?=.*[A-Z]) :       Al menos una mayúscula
3. (?=.*\d)    :       Al menos un número
4. (?=.*[^\da-zA-Z]) : Al menos un símbolo (no alfanumérico)
5. {8,}$:               Define la longitud mínima de 8 caracteres.

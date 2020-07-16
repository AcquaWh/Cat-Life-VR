# Cat Life VR
![MIT License](http://img.shields.io/badge/license-MIT-blue.svg?style=flat)

## Índice

- [Instalación](#instalación)
- [Paquetes instalados](#paquetes-instalados)
- [Introducción](#introducción)
- [Objetivo](#objetivo)
- [Objetivos específicos](#objetivos-específicos)
- [Alcance](#alcance)
- [Dispositivo](#dispositivo)
- [Desarrollo](#desarrollo)
- [Justificación](#justificación)
- [Licencia](#licencia)
- [Conclusión](#conclusión)
- [Licencia](#licencia)
- [Referencias](#referencias)

Cat Life VR es una simulación en realidad virtual que fue creada con Google Cardboard y Daydream en Unity. Este juego tiene un fin educativo para jóvenes de kinder hasta primaria de un rango de edad de 3-11 años donde te enseñara a sumar y restar con frutas. Los niños podrán divertirse mientras están en su salón de clase virtual y aprender al mismo tiempo.

## Instalación

### Versión de Unity

 - Unity 2019.3.0f6 Personal

Clona el repositorio de GitHub en cualquier carpeta dentro de tu computadora

    git clone https://github.com/AcquaWh/Cat-Life-VR.git
    
- Descarga el archivo apk en este [enlace](https://github.com/AcquaWh/Cat-Life-VR/releases/tag/0.1) para instalarlo en tu celular Android.
- Entra en tu celular a Ajustes > seguridad > orígenes desconocidos y actívala.
- Abre el **APK** que descargaste en tu celular y acepta todos los pasos.
- Estará listo para iniciar el juego.

## Paquetes instalados

- GoogleVR
- Photon 2
- Post Processing
- Lightweight RP

## Introducción
La aplicación de nuevas tecnologías dentro de las escuelas y universidades se esta haciendo más habitual, más ahora por la situación que nuestro mundo esta logrando superar haciendo referencia al COVID19. Ya existen herramientas como Zoom, Skype, Discord entre otras para mantenerte comunicado en el ambito laboral y estudiantil sin estar presencialmente dentro de las instalaciones de tu empresa y universidad.

Cuando estaba en el Kinder hasta la primaria inferior en mi escuela La Salle había un juego educativo que nos ponían en el área de computación que era 2D y tenias que resolver distintos puzzles como resolver una ecuación matemática básica, sumar, restar, multiplicar y dividir. También ese juego nos ponían a leer hasta escribir, este juego lo tenia todo y desde ese entonces fue que me llamaron la atención los videojuegos y su creación. De esa idea fue con la que me inspire para desarrollar mi proyecto.

Con el paso del tiempo, se ha incrementado en las computadoras la velocidad de procesamiento, con mayor capacidad de gráficos y de reproducción de sonido. Esto ha
permitido que muy recientemente la tecnología de realidad virtual pueda utilizarse en el proceso enseñanza-aprendizaje, ya que requiere de cierta velocidad de procesamiento en
una PC, respetable cantidad de memoria y una tarjeta de vídeo con aceleración gráfica.

Google en su presentación anual de Google I/O 2014, presenta una caja de cartón que transforma el celular en unas gafas de realidad virtual, el proyecto Cardboard tiene como
objetivo desarrollar la realidad virtual (VR) herramientas de bajo costo para que todos puedan disfrutar VR de manera sencilla, divertida y natural, es tanto así que uno mismo
puede construir estas gafas, el proceso de construcción de unas CardBoard puede resultar relativamente sencillo y se puede completar en unos 15 o 20 minutos.

El presente trabajo propone presentar el desarrollo de un videojuego educativo en realidad virtual desarrollado con Google Cardboard, que pueda colaborar con la enseñanza en los kindergarden y primarias para que enseñen a los niños a sumar y restar con el fin de motivar a los alumnos a aprender de forma divertida aumentando su interés por la clase de matemáticas con la ayuda de sus compañeros de clase.

## Objetivo
Desarrollar un videojuego en realidad virtual para la clase de Realidad Virtual 2 con Google Cardboard usando el modo multijugador para que al menos entre 2-3 personas se conecten a la sala de juegos en línea.

## Objetivos específicos 
- Desarrollar una sala virtual donde se puedan conectar al menos 2 personas dentro de una red.
- Desarrollar una videojuego con realidad virtual para integrar con Google Cardboard.
- Reforzar conocimiento visto en clase de Realidad Virtual 1.

## Alcance
El presente proyecto se desarrolló con la necesidad de hacer un videojuego en realidad virtual que pudiera conectarse con el método multijugador, es decir que se necesitó al menos un dispositivo móvil con el sistema operativo Android y unas gafas de realidad virtual Cardboard para poder desarrollar este proyecto. El trabajo del presente proyecto fue definido dentro de los siguientes alcances:
- Se tomo en cuenta que estamos en cuarentena por el virus de el COVID19 y no se podrá mantener contacto con el profesor físicamente para hacer pruebas con la aplicación.
- Que la aplicación se conectara por el medio multijugador y que se comunicará entre dos cascos mínimo.
- Resolver sumas básicas para niños de kinder-primaria inferior.
- Que el personaje pudiera caminar y explorar la escena.
- Crear diferentes escenas para el inicio (el menu) con sus instrucciones de jugabilidad, la sala de juego multijugador y las escenas si perdiste o ganaste.
- Mostrar paneles desplegables de textos que muestren los ejercicios que se deben resolver.

## Dispositivo
Google Cardboard son unas gafas de realidad virtual que están hechas con cartón plegable, que funciona al montar un celular con Android o iOS. Son unas gafas con el valor de 400 pesos mexicanos con la resolución de un celular en horizontal. Con estos lentes no necesitas una computadora de gaming ni tampoco una profesional, solo necesitas un celular y con eso basta.

## Desarrollo
### Herramientas necesarias para el desarrollo
Para poder desarrollar y aprender a utilizar este proyecto con Unity necesitamos cumplir al menos los requisitos mínimos que cumplir a nivel de hardware, sobre todo nuestro celular.
- Dispositivo Android con sistema operativo Android 7.0 o mayor.
- Unas gafas cardboard.
- Motor gráfico Unity 3D en su versión (2019.3.0f6).
- Extensiones de Unity3D, GoogleVR.

### Instalaciones
Comprobaremos las versiones de nuestros dispositivos, programas y preparación de todos los entornos para una posterior realización del proyecto de videojuego en realidad virtual.
### Celular
Primero deberemos de comprobar la versión de nuestro dispositivo móvil para ello tenemos que acceder a la siguiente ruta:

Ajustes/ Acerca del dispositivo/ Información del software

![android](https://i.ibb.co/1smzQJJ/ex1.png)

Como se observa en la imagen la versión de nuestro dispositivo Android es la 7.0.

Debido a compatibilidades con las librerías de Google VR nuestro dispositivo debe de tener dicha versión como mínimo para poder hacer uso de las funcionalidades que vernos en la guía. Una vez comprobada la versión de nuestro dispositivo deberemos de instalar desde la PlayStore la aplicación Servicios RV de Google, esta aplicación de Google nos proporciona las herramientas necesarias para poder dar, entre otras, un soporte desde Unity3D a nuestro móvil y poder realizar pruebas en vivo de nuestro desarrollo mediante la conexión con un cable USB desde nuestro dispositivo móvil hasta nuestro PC.

![vr](https://i.ibb.co/J5W1CJB/vr.png)

### Cardboard
Aunque no necesario, para poder obtener una experiencia más auténtica de esta tecnología poseer unas cardboard ayudará a conseguir una inmersión en nuestro proyecto más realista.

### Dispositivo de control bluetooth
Como dispositivo de control utilizaremos otro smartphone que simulara un control de las gafas Daydream de Google.

### Unity3D
Con este motor realizaremos el desarrollo del proyecto y veremos las principales funciones que nos proporciona en conjunto a la realidad virtual. Utilizaremos la versión gratuita Unity3D Personal para nuestro desarrollo. Para poder instalar una versión reciente de Unity3D bastará con acceder a esta dirección oficial donde podremos descargar de forma gratuita una versión de Unity3D actualizada. [Enlace a la página de Unity](https://store.unity.com/es/download?ref=personal)

![img](https://i.ibb.co/xhHxFcF/img2.png)

### Punto a tener en cuenta ante la instalación de Unity, preparación del smartphone y preparación del proyecto de Unity
Tener siempre activados durante la instalación de Unity3D que tengamos activado la opcion de Android Build Support y iOS Build Support para poder seguir sin problemas en el desarrollo.

![img](https://i.ibb.co/1vW12Fs/img2.png)

### Habilitar la depuración de USB en el dispositivo
Para habilitar la depuración del dispositivo tendremos que tener activadas las opciones de desarrollador en el terminal. Para ello deberemos de acceder a la siguiente ruta: 
Ajustes > Acerca del dispositivo > Información del software > Numero de compilación

![img](https://i.ibb.co/swy0J4j/img2.png)

![img](https://i.ibb.co/WDdnHFR/info.png)

Una vez estemos en esta pantalla si presionamos 7 veces seguidas sobre el número de compilación se activará automáticamente las opciones de desarrollador.

![img](https://i.ibb.co/jMjZK96/info.png)
Conecte su dispositivo móvil mediante un cable USB a  su computador. Puede que deba de instalar los controladores adecuados a su dispositivo para que se reconozca en su PC.
En el dispositivo móvil, dentro de las opciones de desarrollador deberemos de buscar y activar la opción de depuración de USB para activar el modo de depuración cuando el dispositivo esté conectado a la computadora.

![img](https://i.ibb.co/vXVpjNF/info.png)

### Configuración de proyecto en Unity
Se empezó un proyecto nuevo en 3D en Unity (versión 2019.3.0f6) en donde se importaron los paquetes de GoogleVR desde este [enlace](https://developers.google.com/vr/develop/unity/get-started-android) en la carpeta de Assets.

![img](https://i.ibb.co/RTyxgwX/img2.png)

### Configuración de opciones de construcción y opciones de jugador
Selecciona File > Build Settings

![img](https://i.ibb.co/LNYHpFW/img2.png)

Selecciona Android y haz click en **Swith Platform,**
En la ventana de Build Settings, haz click en **Player Settings.**
Una vez pulsado **Player Settings** deberemos de modificar algunos aspectos desde el menú de la derecha Inspector indicado en la siguiente tabla:

![img](https://i.ibb.co/9vc6nyt/tabla.png)

Una vez configurados estos parámetros ya tendremos preparado el proyecto con todo lo básico para empezar con nuestro desarrollo.

### Procesos de programación

Se crearon las escenas, en la que vendrá el menú, la sala multijugador, cuando pierdes y ganas.

![img](https://i.ibb.co/DbCsVFq/scenes.png)

Utilizando la tienda de assets de Unity ([enlace](https://assetstore.unity.com/)) se descargaron los primeros recursos que fueron las frutas en 3D y el gato que se ve en escena.

Desde la escena de HelloWorld de GoogleVR, copiar los archivos importantes del Player y sus controladores de la cámara en el Hierarchy de la escena **Menú** que se creo con anterioridad.

![img](https://i.ibb.co/XDSJ7KD/scenes.png)

Se creo un escenario en Maya 2019 donde se reutilizara un escenario que ya tenia en la librería y solamente le cambie los cuadros a gatos entre otros ajustes de color a la escena. Cambiando de color el directional light.

![img](https://i.ibb.co/X5ZxmRV/scene.png)

## Justificación
El proyecto se justifica por ser una herramienta de aprendizaje para niños que necesiten aprender matemáticas beneficiándose de escenarios virtuales para nada aburridos.
Desde el punto de vista tecnológico, se empleó herramientas actuales para el desarrollo, como ser Unity 3d como procesador de gráficos en 3D y la aplicación será desarrollada para la plataforma Android. 

SDK Android para Unity nos permitió integrar Android con el gestor Unity 3D. Se utiliza además del visor CardBoard el cual fue lanzado por Google el 2014, como una herramienta
a bajo costo para lograr una realidad virtual en la aplicación.

## Conclusión
Después de tener varias semanas trabajando en el proyecto de Cat Life VR, pude reforzar los conocimientos previos que ya había aprendido en clase de Realidad Virtual 2 y obligarme a investigar más técnicas de otras formas para conectarte en línea por medio de Photon 2.

- El objetivo general fue cumplido ya que se realizo el juego con exito en realidad virtual con Google Cardboard usando la tecnología Photon Pun 2 para crear un servidor virtual para que los usuarios puedan jugar al mismo tiempo en una misma red.
- El sistema de multijugador puede llegar a ser complicado de implementar en proyectos de poco tiempo para desarrollar, así que tengo planeado investigar aun más sobre el tema de realidad virtual en multijugador.
- El costo de las gafas de realidad virtual Google Cardboard es absurdamente barato a diferencia de otros dispositivos como el Oculus rift entre otros, así que no tuve que gastar.
- Se logro trabajar con distintos recursos que tienen licencia gratis de uso, yo lo tuve que implementar en el proyecto y modificar varios materiales.

## Referencias
Yoo, S., & Parker, C. (2015, August). Controller-less interaction methods for Google cardboard. In Proceedings of the 3rd ACM Symposium on Spatial User Interaction (pp. 127-127).

MacIsaac, D. (Ed.). (2015). Google Cardboard: A virtual reality headset for $10?. The Physics Teacher, 53(2), 125-125.

Etxeberría, F. (2001). Videojuegos y educación.

Vera-Muñoz, M. I., & Espinosa Brilla, D. (2001). Efectos de los videojuegos y de la realidad virtual en los valores.

Keene, S. (2018). Google Daydream VR Cookbook: Building Games and Apps with Google Daydream and Unity. Addison-Wesley Professional.

LaValle, S. M., Yershova, A., Katsev, M., & Antonov, M. (2014, May). Head tracking for the Oculus Rift. In 2014 IEEE International Conference on Robotics and Automation (ICRA) (pp. 187-194). IEEE.

Psotka, J. (1995). Immersive training systems: Virtual reality and education and training. Instructional science, 23(5-6), 405-431.

Egger, J., Gall, M., Wallner, J., Boechat, P., Hann, A., Li, X., ... & Schmalstieg, D. (2017). HTC Vive MeVisLab integration via OpenVR for medical applications. PloS one, 12(3), e0173972.

## Licencia
Entra a este [enlace](https://github.com/AcquaWh/VR-Multiplayer/blob/master/LICENSE) para ver la licencia del proyecto.

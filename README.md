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

Cat Life VR es una simulación en realidad virtual que fue creada con Google Cardboard y Daydream en Unity. Este juego tiene un fin educativo para jovenes de kinder hasta primaria de un rango de edad de 3-11 años donde te enseñara a sumar y restar con frutas. Los niños podran divertirse mientras estan en su salón de clase virtual y aprender al mismo tiempo.

## Instalación

### Versión de Unity

 - Unity 2019.3.0f6 Personal

Clona el repositorio de GitHub en cualquier carpeta dentro de tu computadora

    git clone https://github.com/AcquaWh/Cat-Life-VR.git
    
- Descarga el archivo apk en este [enlace](#) para instalarlo en tu celular Android.
- Entra en tu celular a Ajustes > seguridad > orígenes desconocidos y actívala.
- Abre el apk que descargaste en tu celular y acepta todos los pasos.
- Estará listo para iniciar el juego.

## Paquetes instalados

- GoogleVR
- Photon 2
- Post Processing
- Lightweight RP

## Introducción
La aplicación de nuevas tecnologías dentro de las escuelas y universidades se esta haciendo más habitual, más ahora por la situación que nuestro mundo esta logrando superar haciendo referencia al COVID19. Ya existen herramientas como Zoom, Skype, Discord entre otras para mantenerte comunicado en el ambito laboral y estudiantil sin estar presencialmente dentro de las instalaciones de tu empresa y universidad.

Cuando estaba en el Kinder hasta la primaria inferior en mi escuela La Salle habia un juego educativo que nos ponian en el area de computación que era 2D y tenias que resolver distintos puzzles como resolver una ecuación matematica basica, sumar, restar, multiplicar y dividir. También ese juego nos ponian a leer hasta escribir, este juego lo tenia todo y desde ese entonces fue que me llamaron la atención los videojuegos y su creación. De esa idea fue con la que me inspire para desarrollar mi proyecto.

Con el paso del tiempo, se ha incrementado en las computadoras la velocidad de procesamiento, con mayor capacidad de gráficos y de reproducción de sonido. Esto ha
permitido que muy recientemente la tecnología de realidad virtual pueda utilizarse en el proceso enseñanza-aprendizaje, ya que requiere de cierta velocidad de procesamiento en
una PC, respetable cantidad de memoria y una tarjeta de video con aceleración gráfica.

Google en su presentación anual de Google I/O 2014, presenta una caja de cartón que transforma el celular en unas gafas de realidad virtual, el proyecto Cardboard tiene como
objetivo desarrollar la realidad virtual (VR) herramientas de bajo costo para que todos puedan disfrutar VR de manera sencilla, divertida y natural, es tanto así que uno mismo
puede construir estas gafas, el proceso de construcción de unas CardBoard puede resultar relativamente sencillo y se puede completar en unos 15 o 20 minutos.

El presente trabajo propone presentar el desarrollo de un videojuego educativo en realidad virtual desarrollado con Google Cardboard, que pueda colaborar con la enseñanza en los kindergarden y primarias para que enseñen a los niños a sumar y restar con el fin de motivar a los alumnos a aprender de forma divertida aumentando su interes por la clase de matematicas con la ayuda de sus compañeros de clase.

## Objetivo
Desarrollar un videojuego en realidad virtual para la clase de Realidad Virtual 2 con Google Cardboard usando el modo multijugador para que al menos entre 2-3 personas se conecten a la sala de juegos en línea.

## Objetivos específicos 
- Desarrollar una sala virtual donde se puedan conectar al menos 2 personas dentro de una red.
- Desarrollar una videojuego con realidad virtual para integrar con Google Cardboard.
- Reforzar conocimiento visto en clase de Realidad Virtual 1.

## Alcance
El presente proyecto se desarrolló con la necesidad de hacer un videojuego en realidad virtual que pudiera conectarse con el metodo multijugador, es decir que se necesitó al menos un dispositivo movil con el sistema operativo Android y unas gafas de realidad virtual Cardboard para poder desarrollar este proyecto. El trabajo del presente proyecto fue definido dentro de los siguientes alcances:
- Se tomo en cuenta que estamos en cuarentena por el virus de el COVID19 y no se podra mantener contacto con el profesor fisicamente para hacer pruebas con la aplicación.
- Que la aplicación se conectara por el medio multijugador y que se comunicará entre dos cascos mínimo.
- Resolver sumas basicas para niños de kinder-primaria inferior.
- Que el personaje pudiera caminar y explorar la escena.
- Crear diferentes escenas para el inicio (el menu) con sus instrucciones de jugabilidad, la sala de juego multijugador y las escenas si perdiste o ganaste.
- Mostrar paneles desplegables de textos que muestren los ejercicios que se deben resolver.

## Dispositivo
Google Cardboard son unas gafas de realidad virtual que estan hechas con cartón plegable, que funciona al montar un celular con Android o iOS. Son unas gafas con el valor de 400 pesos mexicanos con la resolución de un celular en horizontal. Con estos lentes no necesitas una computadora de gaming ni tampoco una profesional, solo necesitas un celular y con eso basta.

## Desarrollo
### Herramientas necesarias para el desarrollo
Para poder desarollar y aprender a utilizar este proyecto con Unity necesitamos cumplir al menos los requisitos mínimos que cumplir a nivel de hardware, sobre todo nuestro celular.
- Disposito Android con sistema operativo Android 7.0 o mayor.
- Unas gafas cardboard.
- Motor gráfico Unity 3D en su versión (2019.3.0f6).
- Extensiones de Unity3D, GoogleVR.

### Instalaciones
Comprobaremos las versiones de nuestros dispositivos, programas y preparación de todos los entornos para una posterior realización del proyecto de videojuego en realidad virtual.
### Celular
Primero deberemos de comprobar la versión de nuestro dispositivo móvil para ello tenemos que acceder a la siguiente ruta:

Ajustes/ Acerca del dispositivo/ Información del software

![android](https://i.ibb.co/1smzQJJ/ex1.png)

Se empezo un proyecto nuevo en 3D en Unity (versión 2019.3.0f6) en donde se importaron los paquetes de GoogleVR desde este [enlace](https://developers.google.com/vr/develop/unity/get-started-android) en la carpeta de Assets.
Se crearon las primeras escena, en la que vendra el menu y la sala multijugador.
Utilizando la tienda de assets de Unity ([enlace](https://assetstore.unity.com/)) se descargaron los primeros recursos que fueron las frutas en 3D y el gato que se ve en escena.
Desde los prefabs (objeto reutilizable) de GoogleVR, arrastrar al prefab llamado Player en el Hierarchy de la escena "Menu" que se hizo.



## Justificación
El proyecto se justifica por ser una herramienta de aprendizaje para niños que necesiten aprender matematicas beneficiandose de escenarios virtuales para nada aburridos.
Desde el punto de vista tecnológico, se empleó herramientas actuales para el desarrollo, como ser Unity 3d como procesador de gráficos en 3D y la aplicación será desarrollada para la plataforma Android. 

SDK Android para Unity nos permitió integrar Android con el gestor Unity 3D. Se utiliza además del visor CardBoard el cual fue lanzado por Google el 2014, como una herramienta
a bajo costo para lograr una realidad virtual en la aplicación.

## Conclusión
Después de tener varias semanas trabajando en el proyecto de Cat Life VR, pude reforzar los conocimientos previos que ya habia aprendido en clase de Realidad Virtual 2 y obligarme a investigar más tecnicas de otras formas para conectarte en línea por medio de Photon 2.

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

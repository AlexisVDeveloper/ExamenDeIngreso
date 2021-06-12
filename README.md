----> UML : https://drive.google.com/file/d/1vV_9J_VfJKwa84qu7dacD7_1WINYpG1V/view?usp=sharing  <----


Por favor, especifica tu nombre completo: Alexis Miguel Vaglica

1- ¿C# permite herencia múltiple?
No, solo herencia simple.

2- ¿Cuándo utilizaría una Clase Abstracta en lugar de una Interfaz? Ejemplifique.
La clase Abstracta le inda como se comporta de manera general un objeto, es decir que sus hijos heredan sus comportamientos y atributos.
Mientras que la interfaz solo se utiliza para indicar el comportamiento de los objetos que la implementen, sin atributos. 

Ejemplo: 
Armas podría ser una clase Abstracta, la cual tiene atributos como "balas", "componentes", entre otros; tambien posee metodos compartidos como "Disparar" o "Recargar".
Pero las Armas tambien son objetos que se puede agarrar, de esta manera podría implementar la interfaz IAgarrable, la cual tiene como metodo "Agarrar".  

3- ¿Qué implica una relación de Generalización entre dos clases?
Implica una herencia entre un padre y sus hijos.

4- ¿Qué implica una relación de Implementación entre una clase y una interfaz?
Que la interfaz le va a indicar el corportamiento de la clase. 

5- ¿Qué diferencia hay entre la relación de Composición y la Agregación?
Una de las grandes diferencias es que la relación que genera Agregación no liga a sus "partes". 
Mientras que Composición si lo hace, es decir que cuando el objeto "muere" de igual manera lo harán sus "partes."

6- Indique V o F según corresponda. Diferencia entre Asociación y Agregación:
a. Una diferencia es que la segunda indica la relación entre un “todo” y sus “partes”, mientras que en la primera los objetos están al mismo nivel contextual.
Verdadero.

b. Una diferencia es que la Agregación es de cardinalidad 1 a muchos mientras que la Asociación es de 1 a 1. 
Falso, la asociación tambien puede ser de cardinalidad 1 a muchos.

c. Una diferencia es que, en la Agregación, la vida o existencia de los objetos relacionados está fuertemente ligada, es decir que si “muere” el objeto contenedor también morirán las “partes”, en cambio en la Asociación los objetos viven y existen independientemente de la relación. 
Falso, en la agregación la vida o existencia de los objetos no están ligadas de manera que si un objeto muere las "partes van a seguir viviendo".

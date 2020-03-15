# Shape Intersection
## Sergi Collado - Marzo 2020

___Se implementa en .netCore 3.1___

### Diseño

No se toman grandes decisiones de diseño debido al alcance del enunciado, pero aun así se divide la solución en 3 proyectos:

* ___ShapeIntersection___: dominio, servicios, factorias y todo lo necesario para efectuar el cálculo de la intersección de 2 formas dadas.

* ___ShapeIntersection.Test___: Tests unitarios organizados en la misma estructura que _ShapeIntersection_.

* ___ShapeIntersection.Application___: Aplicación de consola para ver resultados más allá de los tests unitarios.

### Implementación

(rama __master__)

* Para simplificar, se supone que las formas se definen sobre los planos ortogonales (sin rotaciones). Se definen las dimensiones de un cubo como su centro (X,Y) y su lado (Side). Se implementan clases específicas para estos valores que permiten evitar _Primitive Obsession_ y poder tener más control sobre el dominio de entrada de datos, así como evitar errores en el orden de los parámetros de los constructores de las dimensiones.

* Se implementa una factoria capaz de devolver una forma concreta mediante el tipo de dimensión correspondiente. En la factoria se utiliza _pattern matching_ para decidir qué forma concreta instanciar.

* Se implementa una clase _BaseShape_ para forzar que cualquier forma requiera que se le pase las dimensiones correspondientes en el constructor.

* Se implementa un servicio de cálculo de intersecciones que se inyecta (mediante la factoria) a la forma, para que así la forma pueda devolver el resultado de su intersección con otra forma. En el cálculo de intersecciones de dicho servicio se ha obviado toda la parte matemática, pero mediante _pattern matching_ y las fórmulas adecuadas se podría calcular la intersección de cualquier par de formas, sean del tipo que sean.

* Se implementa siguiendo _TDD_ y aplicando los principios _SOLID_, _YAGNI_, _KISS_, _DRY_ así como los _4 principles of simple design_.

* Se utiliza _xUnit_ y _NSubstitute_(para _mocks_) en el proyecto de testing.

### Ampliaciones a nuevos tipos de _Shape_ 

(rama __Add_Other_Shape_Type__)

En esta rama se ha ampliado el cálculo de intersección a un nuevo tipo de forma _Sphere_.

* Si se requiere añadir un nuevo tipo de forma, sólo será necesario:

  - Implementar la nueva clase (en este caso _Sphere_) que herede correctamente de _BaseShape_ y cumpla con _IShape_.
  
  - Hacer que la _factory_ sea capaz de generar formas del nuevo tipo.
  
  - Dado que el servicio implementado es suficientemente genérico, en este caso no sería necesario modificarlo, pero si se estuviesen implementando las fórmulas matemáticas correctas de intersección de formas en 3D, entonces debería añadirse o modificarse lo que fuese necesario para calcular la intersección con el nuevo tipo de forma.

### Ejecución y pruebas

(en ambas ramas)

* Se pueden ejecutar los tests del proyecto _ShapeIntersection.Test_ que autodocumentan el uso de la factoria y clases de formas.

* Se puede ejecutar el proyecto _ShapeIntersection.Application_ (_Console Application_) que muestra el resultado de cálculos concretos.

### Mejoras

* El resultado de la intersección (clase _ShapeIntersection_) también puede ser una forma que se pueda interseccionar con otras formas. Bastaría con hacer que la clase cumpliese con _IShape_ y definir los métodos del contrato (no sería necesário que heredase de _BaseShape_). Matemáticamente esto aumentaría considerablemente la complejidad.

* El uso de _factory_ podria ser cuestionable si el escenario se redujese sólo a casos sencillos, pero cuando la complejidad aumenta se resuelve como un patrón de diseño muy útil para lidiar con dicha complejidad.

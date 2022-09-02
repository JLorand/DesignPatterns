# Singleton Design Pattern
The Singleton design pattern ensures a class has only one instance and provide a global point of access to it.

## UML class diagram
![](https://www.dofactory.com/img/diagrams/net/Singleton.png)

## Participants
* _Singleton_  (LoadBalancer)
    * defines an Instance operation that lets clients access its unique instance. Instance is a class operation.
    * responsible for creating and maintaining its own unique instance.

## Thoughts
* Consider using IoC container add singletion feature.
```
services.AddSingleton<ISingleton>(new Singleton("WithArgument"));
```
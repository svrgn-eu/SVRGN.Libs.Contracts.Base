[TOC]

# About

This package is a collection of interfaces used by the free SVRGN libs. It includes basic interfaces to be inherited from and to be relied on.

Interfaces are

- IBaseObject - base interface for grouping all used objects
- IClear - providing a Clear() method for clearing the screen or similar tasks
- IError - describing an Error interface also with hints for the user
- IId - provides a simple Guid Id 
- IInitialize - helps to steer the initialization logic of classes
- IName - provides a Name property
- IOrderBy -  provides an Order property for having some visual ordering
- IUpdate - helps with Update logic
- IFromMermaid - forces the class to implement a mermaid diagram import method if applicable (e.g. State Machines)
- IToMermaid - forces the class to implement a mermaid export methods if needed

# How to use
Use Cases and Examples
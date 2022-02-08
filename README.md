# SingleResponsability

- Un módulo solo debe tener un motivo para cambiar.

## La clase OrderService se encarga de agregar ordenes, pero delega el envío de mails al notificationService, 
dejando la responsabilidad de conexión al smtp server y envío de mail en sus clases correspondientes.

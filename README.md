# Airport API EFCore
Airport REST API with Entity Framework

При первом запуске приложения создается бд и подгружаются Seed данные.

Пресудствует папка Migration, которая хранит миграции бд(подгружаются при запуске)

Работа с DbContext и DbSet обернута в UnitOfWork с репозиториями.

API Structure : https://docs.google.com/document/d/1avfB1I-dX2RRWpU8z7bESD5k4YjGGpyNclOSTZjZ-g8/edit?usp=sharing

## CRUD

 Read : [GET] GetAll api/[controller] , GetById api/[controller]/:id

Create : [POST] api/[controller] Body: Object in JSON format

 Update : [PUT] api/[controller]/:id Body: Object in JSON format

 Delete : [DELETE] api/[controller]/:id

### Models(Controller name) :
Flight

Departure

Crew

Pilot

Stewardess

Aircraft

AircraftType

Ticket

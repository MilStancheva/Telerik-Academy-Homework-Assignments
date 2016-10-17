## Database Systems - Overview
### _Homework_

#### Answer following questions in Markdown format (`.md` file)

1.  What database models do you know?
    - Relational Database Systems
        - Hierarchical (tree)
        - Network (graph)
        - Relational (table)
        - Object-oriented  

    - Non-relational data models
        - Document model
        - Key-value model
        - Hierarchical key-value pairs
        - Wide-column model
        - Object model

1.  Which are the main functions performed by a Relational Database Management System (RDBMS)?

    Manage data stored in tables. RDBMS implement creating, altering, deleting tables and relationships between them. 
    They also perform adding, changing, deleting, searching and retreiving data stored in tables. RDBMS support the SQL language. 

1.  Define what is "table" in database terms.
    
    Tables consist of data stored in rows and columns. They are a schema of ordered sequence of column specifications (name & type). 
    All rows have the same structure. Columns have name and type. 

1.  Explain the difference between a primary and a foreign key.
    - Primary key is a column of the table that uniquely identifies its rows (usually as a unique number).
    - The Foreign key is an identifier of a record located in another table (ususally it is its primary key). 
    
    Primary keys and Foreign keys are used to create relationships between tables. The primary key is a unique key located in the current table and a foregn key is a primary key of another table located in the current one. 

1.  Explain the different kinds of relationships between tables in relational databases: There are 4 types of relationships in the relational databases:
    - One-to-many
        - For example, one school with many students
    - Many-to-many
        - For example, more than one students attend several courses; This kind of relationship is represented by a third table indicating the primary keys of the tables to be related
    - One-to-one 
        - For example, the student is a human. It is used to model inheritance between tables
    - Self-relationship
        - The primary and the foreign key point to one and the same table  

1.  When is a certain database schema normalized?
    A database is normalized when there are no duplications of the data. It is a standard to prevent repeating data. 
  * What are the advantages of normalized databases?
    The advantages - easy access, fast changes, no duplicated data. 

1.  What are database integrity constraints and when are they used? 
    - The integrity constraints ensure data integrity at the data tables. Enforse data rules which cannot be violated. 
        - Primary key constraint: Еnsures that the primary key of the table has a unique value for each table row. 
        - Unique key consstraint: Еnsures that all values in a certain column (or a group of columns) are unique. 
        - Foreign key constraint: Еnsures that the value of a given column is the primary key of another table. 
        - Check constraint: Еnsures that values in a given column meet some predefined conditions. 

1.  Point out the pros and cons of using indexes in a database.
    - Pros: speed up searching of values in a certain column or grouup of columns. 
    - Cons: adding and deleting records in an indexed table is slow. 

1.  What's the main purpose of the SQL language?
    Supports creatig, altering and deleting tables and other objects in the database.Provide searching, retrieving, inserting, modifying and deleting table data(rows). 

1.  What are transactions used for?
    Transactions are used for a sequence of database operations to be executed at once. Either all operations are executed or in a case of fail, none is executed at all.
    They guarantee consistency and integrity in the database.
  * Give an example.
    A great example are bank transactions. If a bank transefer has started to execute, either it is completed, or it fails. Otherways it can be executed several times which can lead to mony loses or to infrormation that is not true.

1.  What is a NoSQL database?
    NoSQL is a non-relational database. It supports operations like create, read, update, delete data. NoSQL databases represent schema-free document structure.
    NoSQL databases have great performace and scalability.  

1.  Explain the classical non-relational data models.
    The data is srored as documents. Every document is a single entity - a single record. 
    The documents do not have a fixed structure. 

1.  Give few examples of NoSQL databases and their pros and cons.
    - Pros: 
        - High performance and scalability 
        - Highly optimized for apped/ retrieve of data
    - Cons: 
        - A great disavdantage is the lack of consistency in the data
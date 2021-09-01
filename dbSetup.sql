CREATE TABLE IF NOT EXISTS accounts(
  id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  name varchar(255) COMMENT 'User Name',
  email varchar(255) COMMENT 'User Email',
  picture varchar(255) COMMENT 'User Picture'
) default charset utf8 COMMENT '';

CREATE TABLE castles(
  id int NOT NULL primary key AUTO_INCREMENT comment 'primary key',
  name varchar(255) NOT NULL comment 'castles name'
) default charset utf8;

CREATE TABLE knights(
  id int NOT NULL primary key AUTO_INCREMENT comment 'primary key',
  name varchar(255) NOT NULL comment 'knights name',
  castleId int NOT NULL,
  FOREIGN KEY (castleId) REFERENCES castles(id) ON DELETE CASCADE
);


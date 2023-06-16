drop TABLE category cascade CONSTRAINTS;
drop TABLE transaction cascade CONSTRAINTS;

CREATE SEQUENCE category_seq START WITH 1 INCREMENT BY 1;
CREATE SEQUENCE transaction_seq START WITH 1 INCREMENT BY 1;

-- Crear tabla "category"
CREATE TABLE category (
  idCategory NUMBER PRIMARY KEY,
  name VARCHAR2(50),
  description VARCHAR2(100)
);

-- Crear tabla "transaction"
CREATE TABLE transaction (
  idTransaction NUMBER PRIMARY KEY,
  quantity NUMBER,
  description VARCHAR2(100),
  transactionDate DATE,
  idCategory NUMBER,
  type VARCHAR2(50),
  FOREIGN KEY (idCategory) REFERENCES category(idCategory)
);


INSERT INTO category (idCategory, name, description)
VALUES (category_seq.NEXTVAL, 'salary', 'income from your job');

INSERT INTO category (idCategory, name, description)
VALUES (category_seq.NEXTVAL, 'interest', 'profitability of your investments');

INSERT INTO category (idCategory, name, description)
VALUES (category_seq.NEXTVAL, 'feeding', 'household food expenses');

INSERT INTO category (idCategory, name, description)
VALUES (category_seq.NEXTVAL, 'transport', 'expenses in gasoline, bus, taxi ...');

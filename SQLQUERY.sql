USE apinfo;

CREATE TABLE candidato(
nome varchar(255),
sexo varchar(10),
nascimento Date,
estado varchar(100),
cidade varchar(255),
cep varchar(9),
bairro varchar(100),
telefone varchar(100),
email varchar(100),
cpf varchar(11),
senha varchar(20),
frasesecreta varchar(200),
curriculo varchar(255),
PRIMARY KEY (cpf)
);


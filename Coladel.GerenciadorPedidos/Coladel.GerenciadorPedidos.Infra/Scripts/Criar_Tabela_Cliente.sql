CREATE TABLE cliente (
    id SMALLINT(6) AUTO_INCREMENT PRIMARY KEY,
    data_cadastro DATETIME(6) NOT NULL,
    guid CHAR(36) NOT NULL,
    id_endereco SMALLINT(6),
    cnpj VARCHAR(14) NOT NULL,
    inscricao_estadual VARCHAR(12),
    nome_fantasia VARCHAR(256),
);
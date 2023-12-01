-- enderecos

CREATE TABLE `enderecos` (
  `id` smallint(6) NOT NULL AUTO_INCREMENT,
  `guid` char(36) NOT NULL,
  `data_cadastro` datetime(6) NOT NULL,
  `cep` varchar(10) DEFAULT NULL,
  `logradouro` varchar(126) DEFAULT NULL,
  `numero` varchar(5) DEFAULT NULL,
  `complemento` varchar(126) DEFAULT NULL,
  `bairro` varchar(26) DEFAULT NULL,
  `cidade` varchar(26) DEFAULT NULL,
  `estado` varchar(2) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- tributos

CREATE TABLE `tributos` (
  `id` smallint(6) NOT NULL AUTO_INCREMENT,
  `guid` char(36) NOT NULL,
  `data_cadastro` datetime(6) NOT NULL,
  `crt` varchar(5) DEFAULT NULL,
  `irpj` varchar(5) DEFAULT NULL,
  `pis` varchar(5) DEFAULT NULL,
  `csll` varchar(5) DEFAULT NULL,
  `cofins` varchar(5) DEFAULT NULL,
  `iss` varchar(5) DEFAULT NULL,
  `inss` varchar(5) DEFAULT NULL,
  `credito_icms` varchar(5) DEFAULT NULL,
  `cst_ipi` varchar(5) DEFAULT NULL,
  `cst_icms` varchar(5) DEFAULT NULL,
  `cst_pis` varchar(5) DEFAULT NULL,
  `cst_cofins` varchar(5) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- produtos definition

CREATE TABLE `produtos` (
  `id` smallint(6) NOT NULL AUTO_INCREMENT,
  `guid` char(36) NOT NULL,
  `data_cadastro` datetime(6) NOT NULL,
  `nome_produto` longtext DEFAULT NULL,
  `preco` decimal(65,30) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- configuracoes definition

CREATE TABLE `configuracoes` (
  `id` smallint(6) NOT NULL AUTO_INCREMENT,
  `guid` char(36) NOT NULL,
  `data_cadastro` datetime(6) NOT NULL,
  `mostrar_comissao` tinyint(1) DEFAULT 0,
  `enviar_logistica` tinyint(1) DEFAULT 0,
  `enviar_transportadora` tinyint(1) DEFAULT 0,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- fiscal definition

CREATE TABLE `fiscal` (
  `id` smallint(6) NOT NULL AUTO_INCREMENT,
  `guid` char(36) NOT NULL,
  `data_cadastro` datetime(6) NOT NULL,
  `emiti_nfe` bit(1) DEFAULT NULL,
  `emiti_nfse` bit(1) DEFAULT NULL,
  `certificado_digital` varchar(512) DEFAULT NULL,
  `id_tributos` smallint(6) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- contatos definition

CREATE TABLE `contatos` (
  `id` smallint(6) NOT NULL AUTO_INCREMENT,
  `guid` char(36) NOT NULL,
  `data_cadastro` datetime(6) NOT NULL,
  `email` varchar(126),
  `telefone` varchar(12),
  `celular` varchar(14),
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- cliente definition

CREATE TABLE `cliente` (
  `id` smallint(6) NOT NULL AUTO_INCREMENT,
  `id_endereco` smallint(6) DEFAULT NULL,
  `guid` char(36) NOT NULL,
  `data_cadastro` datetime(6) NOT NULL,
  `nome_cliente` varchar(256) DEFAULT NULL,
  `cnpj` varchar(14) DEFAULT NULL,
  `inscricao_estadual` varchar(12) DEFAULT NULL,
  `nome_fantasia` varchar(256) DEFAULT NULL,
  `razao_social` varchar(256) DEFAULT NULL,
  PRIMARY KEY (`id`),
  CONSTRAINT `fk_cliente_endereco` FOREIGN KEY (`id_endereco`) REFERENCES `enderecos` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- emails definition

CREATE TABLE `emails` (
  `id` smallint(6) NOT NULL AUTO_INCREMENT,
  `id_cliente` smallint(6) NOT NULL,
  `guid` char(36) NOT NULL,
  `data_cadastro` datetime(6) NOT NULL,
  `email` varchar(256) NOT NULL,
  PRIMARY KEY (`id`),
  CONSTRAINT `fk_emails_cliente` FOREIGN KEY (`id_cliente`) REFERENCES `cliente` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- empresa definition

CREATE TABLE `empresa` (
  `id` smallint(6) NOT NULL AUTO_INCREMENT,
  `id_configuracao` smallint(6) DEFAULT NULL,
  `guid` char(36) NOT NULL,
  `data_cadastro` datetime(6) NOT NULL,
  `razao_social` varchar(256) NOT NULL,
  `nome_fantasia` varchar(256) DEFAULT NULL,
  `tipo_pessoa` varchar(30) NOT NULL,
  `documento_principal` varchar(30) DEFAULT NULL,
  `documento_secundario` varchar(30) DEFAULT NULL,
  `tipo_doc_principal` varchar(30) DEFAULT NULL,
  `tipo_doc_secundario` varchar(30) DEFAULT NULL,
  `id_endereco` smallint(6) DEFAULT NULL,
  `id_fiscal` smallint(6) DEFAULT NULL,
  PRIMARY KEY (`id`),
  CONSTRAINT `fk_empresa_configuracao` FOREIGN KEY (`id_configuracao`) REFERENCES `configuracoes` (`id`),
  CONSTRAINT `fk_empresa_fiscal` FOREIGN KEY (`id_fiscal`) REFERENCES `fiscal` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- pedidos definition

CREATE TABLE `pedidos` (
  `id` smallint(6) NOT NULL AUTO_INCREMENT,
  `id_cliente` smallint(6) NOT NULL,
  `guid` char(36) NOT NULL,
  `data_cadastro` datetime(6) NOT NULL,
  `status` smallint(6) NOT NULL,
  `nf` varchar(12) DEFAULT NULL,
  `observacoes` longtext DEFAULT NULL,
  `total` decimal(65,30) NOT NULL,
  `total_comissao` decimal(65,2) NOT NULL DEFAULT 0.00,
  PRIMARY KEY (`id`),
  CONSTRAINT `fk_pedidos_cliente` FOREIGN KEY (`id_cliente`) REFERENCES `cliente` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- itens_pedido definition

CREATE TABLE `itens_pedido` (
  `id` smallint(6) NOT NULL AUTO_INCREMENT,
  `id_pedido` smallint(6) NOT NULL,
  `id_produto` smallint(6) NOT NULL,
  `guid` char(36) NOT NULL,
  `data_cadastro` datetime(6) NOT NULL,
  `quantidade` int(11) NOT NULL,
  `preco` decimal(65,2) NOT NULL,
  PRIMARY KEY (`id`),
  CONSTRAINT `fk_itens_pedido_pedido` FOREIGN KEY (`id_pedido`) REFERENCES `pedidos` (`id`),
  CONSTRAINT `fk_itens_pedido_produto` FOREIGN KEY (`id_produto`) REFERENCES `produtos` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- transportadoras definition

CREATE TABLE `transportadoras` (
  `id` smallint(6) NOT NULL AUTO_INCREMENT,
  `id_contato` smallint(6) DEFAULT NULL,
  `id_endereco` smallint(6) DEFAULT NULL,
  `guid` char(36) NOT NULL,
  `data_cadastro` datetime(6) NOT NULL,
  `razao_social` varchar(126) DEFAULT NULL,
  `nome_fantasia` varchar(126) DEFAULT NULL,
  `cod_transportadora` varchar(10) DEFAULT NULL,
  `observacao` varchar(256) DEFAULT NULL,
  `website` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id`),
  CONSTRAINT `fk_transportadoras_contato` FOREIGN KEY (`id_contato`) REFERENCES `contatos` (`id`),
  CONSTRAINT `fk_transportadoras_endereco` FOREIGN KEY (`id_endereco`) REFERENCES  `enderecos` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- envio_emails definition

CREATE TABLE `envio_emails` (
  `id` smallint(6) NOT NULL AUTO_INCREMENT,
  `id_empresa` smallint(6) NOT NULL,
  `guid` char(36) NOT NULL,
  `data_cadastro` datetime(6) NOT NULL,
  `email` varchar(50) DEFAULT NULL,
  `senha` varchar(50) DEFAULT NULL,
  `port` int(11) NOT NULL,
  `smtp_cliente` varchar(50) DEFAULT NULL,
  `tipo_email` int(11) NOT NULL,
  `assunto` longtext DEFAULT NULL,
  `mensagem` longtext DEFAULT NULL,
  `is_origem` tinyint(1) DEFAULT 0,
  PRIMARY KEY (`id`),
  CONSTRAINT `fk_envio_emails_empresa` FOREIGN KEY (`id_empresa`) REFERENCES `empresa` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;




CREATE TABLE obras (
id_obra INT IDENTITY(1,1) PRIMARY KEY,
nome_obra NVARCHAR(200) NOT NULL,
sigla_obra VARCHAR(20) NULL,
data_entrega DATE NULL,
status VARCHAR(20) NOT NULL
);

CREATE TABLE pecas (
id_peca INT IDENTITY(1,1) PRIMARY KEY,
nome_peca NVARCHAR(255) NOT NULL,
data DATE NOT NULL,
volume_mcub DECIMAL(10,2) NULL,
peso_kg DECIMAL(10,2) NULL,
status VARCHAR(30) NOT NULL,
id_obra INT NOT NULL FOREIGN KEY REFERENCES obras(id_obra)
);

CREATE TABLE regioes (
id_regiao INT IDENTITY(1,1) PRIMARY KEY,
nome NVARCHAR(255) NOT NULL
);

CREATE TABLE acabamentos (
    id_acabamento INT IDENTITY(1,1) PRIMARY KEY,
    id_peca INT NOT NULL FOREIGN KEY REFERENCES pecas(id_peca) ON DELETE CASCADE,
    data_inicio DATE NOT NULL,
    data_fim DATE NOT NULL,
    status VARCHAR(30) NOT NULL,
    id_regiao INT NOT NULL FOREIGN KEY REFERENCES regioes(id_regiao)
);

CREATE TABLE estoques (
    id_acabamento INT NOT NULL FOREIGN KEY REFERENCES acabamentos(id_acabamento) ON DELETE CASCADE,
    id_peca INT NOT NULL FOREIGN KEY REFERENCES pecas(id_peca), -- sem cascade aqui
    id_regiao INT NOT NULL FOREIGN KEY REFERENCES regioes(id_regiao),
    total INT NOT NULL,
    data DATE NOT NULL,
    status VARCHAR(30) NOT NULL,
    PRIMARY KEY (id_peca, id_acabamento)
);
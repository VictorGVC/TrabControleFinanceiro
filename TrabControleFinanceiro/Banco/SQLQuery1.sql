CREATE TABLE tipo_despesa(
  tip_codigo integer identity(1,1) NOT NULL,
  tip_nome   varchar(20),
  CONSTRAINT pk_tipodespesa PRIMARY KEY (tip_codigo)
);

CREATE TABLE lancamentos(
  lan_codigo     integer identity(1,1) NOT NULL,
  lan_data       datetime,
  tip_codigo     integer NOT NULL,
  lan_tipo       char(1),
  lan_compensado char(1),
  lan_valor      decimal(8,2),
  CONSTRAINT pk_lancamentos PRIMARY KEY (lan_codigo),
  CONSTRAINT c_tipo CHECK (lan_tipo in ('D','C')),
  CONSTRAINT c_compensado CHECK (lan_compensado in ('S','N')),
  CONSTRAINT fk_lancDespesa FOREIGN KEY (tip_codigo)
                 REFERENCES tipo_despesa
);
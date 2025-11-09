DROP DATABASE IF EXISTS MUSICDEX;

CREATE DATABASE MUSICDEX;

USE MUSICDEX;

CREATE TABLE genero (
  id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
  nome VARCHAR(100) NOT NULL,
  descricao TEXT NULL,
  criado_em TIMESTAMP NOT NULL DEFAULT(NOW()),
  atualizado_em TIMESTAMP NOT NULL DEFAULT(NOW())
);

CREATE TABLE musica (
  id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
  titulo VARCHAR(200) NOT NULL,
  artista VARCHAR(150) NULL,
  album VARCHAR(150) NULL,
  duracao_segundos INT NULL,
  lancamento DATE NULL,
  descricao TEXT NULL,
  imagem_base64 LONGTEXT NULL,
  genero_id INT NULL,
  FOREIGN KEY (genero_id) REFERENCES genero(id),
  criado_em TIMESTAMP NOT NULL DEFAULT(NOW()),
  atualizado_em TIMESTAMP NOT NULL DEFAULT(NOW())
);

INSERT INTO genero (id, nome, descricao, criado_em, atualizado_em) VALUES
(1, 'Pop', 'Músicas populares / chart pop', '2025-11-09 12:00:00', '2025-11-09 12:00:00'),
(2, 'R&B / Synth-pop', 'R&B, synth-pop e afins', '2025-11-09 12:00:00', '2025-11-09 12:00:00'),
(3, 'Alternative', 'Alternative / indie / experimental', '2025-11-09 12:00:00', '2025-11-09 12:00:00');

INSERT INTO musica
  (titulo, artista, album, duracao_segundos, lancamento, descricao, imagem_base64, genero_id, criado_em, atualizado_em)
VALUES
(
  'Blinding Lights',
  'The Weeknd',
  'After Hours',
  202,
  '2019-11-29',
  'Single do álbum After Hours (synth-pop/electropop).',
  'https://upload.wikimedia.org/wikipedia/en/e/e6/The_Weeknd_-_Blinding_Lights.png',
  2,
  '2025-11-09 12:00:00',
  '2025-11-09 12:00:00'
),
(
  'Shape of You',
  'Ed Sheeran',
  '÷ (Divide)',
  234,
  '2017-01-06',
  'Single de Ed Sheeran, enorme sucesso global.',
  'https://m.media-amazon.com/images/I/B1HYJn9MrPS._UF1000,1000_QL80_.jpg',
  1,
  '2025-11-09 12:00:00',
  '2025-11-09 12:00:00'
),
(
  'bad guy',
  'Billie Eilish',
  'When We All Fall Asleep, Where Do We Go?',
  194,
  '2019-03-29',
  'Single de Billie Eilish (minimal electropop / trap-pop).',
  'https://i.scdn.co/image/ab67616d0000b27350a3147b4edd7701a876c6ce',
  3,
  '2025-11-09 12:00:00',
  '2025-11-09 12:00:00'
);

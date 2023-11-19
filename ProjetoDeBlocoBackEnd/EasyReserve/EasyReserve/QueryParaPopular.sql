-- Inserir dados na tabela Hotel
INSERT INTO Hotel (Name, Address, Description)
VALUES
    ('Hotel Bela Vista', 'Rua das Flores, 123, Centro, Cidade Alegre', 'Um hotel com vista panorâmica para a cidade.'),
    ('Hotel Estrela do Norte', 'Avenida Principal, 456, Bairro Tranquilo, Cidade Serena', 'Conforto e tranquilidade em uma localização privilegiada.'),
    ('Hotel Tropical', 'Praia dos Coqueiros, 789, Beira-Mar, Cidade do Sol', 'Aproveite suas férias em um paraíso tropical.'),
    ('Hotel das Montanhas', 'Rua da Serra, 101, Sítio das Montanhas, Cidade Alta', 'Uma experiência única nas alturas.'),
    ('Hotel da Floresta', 'Estrada da Floresta, S/N, Reserva Ecológica, Cidade Verde', 'Conecte-se com a natureza em um ambiente sustentável.'),
    ('Hotel Luxo Palace', 'Avenida dos Sonhos, 1111, Bairro dos Ricos, Cidade dos Sonhos', 'Luxo e exclusividade em cada detalhe.'),
    ('Hotel do Mar', 'Rua Beira-Mar, 222, Porto das Ondas, Cidade Marítima', 'Desfrute da brisa do mar em um ambiente elegante.'),
    ('Hotel das Estrelas', 'Avenida da Astronomia, 333, Céu Noturno, Cidade Celestial', 'Um hotel perfeito para os amantes do espaço.'),
    ('Hotel Sossego do Campo', 'Estrada da Paz, 456, Interior Tranquilo, Cidade Sossegada', 'Relaxe no campo com conforto e serenidade.'),
    ('Hotel Vila Colonial', 'Rua Histórica, 789, Centro Histórico, Cidade Antiga', 'Hospede-se em um ambiente que preserva a história.');

-- Inserir dados na tabela Room
INSERT INTO Room (HotelId, Number, Type, Description, Price, IsReserved)
VALUES
    (1, 101, 'Standard', 'Quarto confortável com vista para a cidade.', 120.00, 0),
    (1, 102, 'Suite', 'Suite espaçosa com banheira de hidromassagem.', 200.00, 0),
    (2, 201, 'Econômico', 'Quarto simples e econômico para viajantes.', 80.00, 0),
    (2, 202, 'Deluxe', 'Quarto de luxo com vista panorâmica.', 250.00, 0),
    (3, 301, 'Frente ao Mar', 'Quarto com varanda de frente para a praia.', 180.00, 0),
    (3, 302, 'Bungalow', 'Bungalow privativo em meio à natureza exuberante.', 300.00, 0),
    (4, 401, 'Montanha View', 'Quarto com vista deslumbrante para as montanhas.', 160.00, 0),
    (4, 402, 'Cabana', 'Cabana aconchegante para uma experiência única.', 220.00, 0),
    (5, 501, 'Eco Suite', 'Suite ambientalmente amigável com energia renovável.', 190.00, 0),
    (5, 502, 'Treehouse', 'Treehouse exclusiva para os aventureiros.', 280.00, 0);

-- Inserir dados na tabela Client
INSERT INTO Client (Name, Email, Phone)
VALUES
    ('Maria da Silva', 'maria.silva@email.com', '11 98765-4321'),
    ('João Oliveira', 'joao.oliveira@email.com', '21 99876-5432'),
    ('Ana Souza', 'ana.souza@email.com', '31 98765-1234'),
    ('Pedro Santos', 'pedro.santos@email.com', '41 99876-2345'),
    ('Carla Pereira', 'carla.pereira@email.com', '51 98765-3456'),
    ('Lucas Lima', 'lucas.lima@email.com', '61 99876-4567'),
    ('Mariana Rocha', 'mariana.rocha@email.com', '71 98765-5678'),
    ('Rafael Costa', 'rafael.costa@email.com', '81 99876-6789'),
    ('Juliana Almeida', 'juliana.almeida@email.com', '91 98765-7890'),
    ('Fernando Oliveira', 'fernando.oliveira@email.com', '12 99876-8901');

-- Inserir dados na tabela Reserve
INSERT INTO Reserve (RoomId, ClientId, Number, CheckIn, CheckOut, TotalCost)
VALUES
    (1, 1, 1, '2023-01-01', '2023-01-03', 240.00),
    (2, 2, 1, '2023-02-01', '2023-02-05', 400.00),
    (3, 3, 1, '2023-03-01', '2023-03-05', 160.00),
    (4, 4, 1, '2023-04-01', '2023-04-03', 450.00),
    (5, 5, 1, '2023-05-01', '2023-05-07', 360.00),
    (6, 6, 1, '2023-06-01', '2023-06-05', 600.00),
    (7, 7, 1, '2023-07-01', '2023-07-03', 320.00),
    (8, 8, 1, '2023-08-01', '2023-08-05', 480.00),
    (9, 9, 1, '2023-09-01', '2023-09-07', 420.00),
    (10, 10, 1, '2023-10-01', '2023-10-03', 560.00);

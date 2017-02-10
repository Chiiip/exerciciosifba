puts "Insira a primeira nota"
media = 0
cont = 0.0
nota = gets.to_i
while nota != -1 do
media = media + nota
cont = cont + 1
puts "Insira a proxima nota"
nota = gets.to_i
end

total = media/cont

puts "A media dos alunos eh "
puts total
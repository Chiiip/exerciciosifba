json.array!(@cursos) do |curso|
  json.extract! curso, :id, :name, :numeroalunos
  json.url curso_url(curso, format: :json)
end

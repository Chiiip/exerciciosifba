json.array!(@turmas) do |turma|
  json.extract! turma, :id, :name
  json.url turma_url(turma, format: :json)
end

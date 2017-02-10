json.array!(@alunos) do |aluno|
  json.extract! aluno, :id, :name, :phone, :email
  json.url aluno_url(aluno, format: :json)
end

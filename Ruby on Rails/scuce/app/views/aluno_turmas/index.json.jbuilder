json.array!(@aluno_turmas) do |aluno_turma|
  json.extract! aluno_turma, :id, :numfaltas
  json.url aluno_turma_url(aluno_turma, format: :json)
end

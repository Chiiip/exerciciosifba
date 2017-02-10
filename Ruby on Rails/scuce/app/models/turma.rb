class Turma < ActiveRecord::Base
	belongs_to :professor
	belongs_to :curso
	has_many :aluno_turmas
end

class Aluno < ActiveRecord::Base

		validates_presence_of :email, :name, :phone, message: 'campo obrigatorio, preencha esse campo'
	has_many :aluno_turmas
end

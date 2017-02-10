class Curso < ActiveRecord::Base
		validates_presence_of :numeroalunos, :name, message: 'campo obrigatorio, preencha esse campo'
	has_many :turmas
end

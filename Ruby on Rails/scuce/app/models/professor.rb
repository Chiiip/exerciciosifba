class Professor < ActiveRecord::Base

	validates_presence_of :email, :name, :phone, :password, message: 'campo obrigatorio, preencha esse campo'
validates_confirmation_of :password, :on => :create, message: '  A confirmacao da senha esta errada, digite a senha certa'
	has_many :turmas



	scope :verify, -> {where.not(email: nil)}

def self.authenticate2(email, password)
	professor = verify.find_by(email: email)
	if professor.present?
		if professor.password == password
			professor
		end
	end
end

end

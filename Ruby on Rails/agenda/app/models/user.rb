class User < ActiveRecord::Base

validates_presence_of :email, :fullname, :location, :password, message: ' e um campo obrigatorio que nao foi preenchido' end
validates_confirmation_of :password, :on => :create, message: '  A confirmacao da senha esta errada, digite a senha certa' end

has_many :contacts
has_many :enterprises


scope :verify, -> {where.not(email: nil)}

def self.authenticate(email, password)
	user = verify.find_by(email: email)
	if user.present?
		if user.password == password
			user
		end
	end

#.try(:authenticate, password)
#user = User.where(["email = ?", email])
end





end



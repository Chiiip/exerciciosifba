class Admin < ActiveRecord::Base	


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

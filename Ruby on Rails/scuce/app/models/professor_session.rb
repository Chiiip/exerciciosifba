class ProfessorSession
	include ActiveModel::Model
	
	attr_accessor :email, :password	
	
	validates_presence_of :email, :password

	def initialize(session, attributes={})
		@session = session
		@email = attributes[:email]
		@password = attributes[:password]
	end

	def authenticate
			professor = Professor.authenticate2(@email, @password)
				if professor.present?
					store(professor)
				else
					errors.add(:base, :invalid_login)
					false
				end	
		end

	def store(professor)
		@session [:professor_id] = professor.id
	end


	def current_professor
		Professor.find(@session[:professor_id])
	end


	def professor_signed_in?
		@session [:professor_id].present?
	end

	def destroy
		@session[:professor_id] = nil
	end

end	